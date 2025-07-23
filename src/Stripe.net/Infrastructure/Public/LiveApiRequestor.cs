namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe.Infrastructure;

    /// <summary>Primary implementation of the ApiRequestor abstract class.</summary>
    internal class LiveApiRequestor : ApiRequestor
    {
        internal static readonly List<string> RawRequestUsage = new List<string> { "raw_request" };
        private JsonSerializerSettings jsonSerializerSettings;
        private StripeClientOptions clientOptions;
        private List<string> defaultUsage;

        public LiveApiRequestor(StripeClientOptions options, List<string> defaultUsage = null)
        {
            // Clone the object passed in, or use an empty option object if it is null
            options = options?.Clone() ?? new StripeClientOptions();

            if (options.ApiKey != null && options.ApiKey.Length == 0)
            {
                throw new ArgumentException("API key cannot be the empty string.", nameof(options.ApiKey));
            }

            if (options.ApiKey != null && StringUtils.ContainsWhitespace(options.ApiKey))
            {
                throw new ArgumentException("API key cannot contain whitespace.", nameof(options.ApiKey));
            }

            this.clientOptions = options;
            this.ApiKey = options.ApiKey;
            this.ClientId = options.ClientId;
            this.HttpClient = options.HttpClient ?? BuildDefaultHttpClient();
            this.ApiBase = options.ApiBase ?? DefaultApiBase;
            this.ConnectBase = options.ConnectBase ?? DefaultConnectBase;
            this.FilesBase = options.FilesBase ?? DefaultFilesBase;
            this.MeterEventsBase = options.MeterEventsBase ?? DefaultMeterEventsBase;
            this.defaultUsage = defaultUsage ?? new List<string>();
            this.jsonSerializerSettings = StripeConfiguration.DefaultSerializerSettings(this);
        }

        /// <summary>Default base URL for Stripe's API.</summary>
        public static string DefaultApiBase => "https://api.stripe.com";

        /// <summary>Default base URL for Stripe's OAuth API.</summary>
        public static string DefaultConnectBase => "https://connect.stripe.com";

        /// <summary>Default base URL for Stripe's Files API.</summary>
        public static string DefaultFilesBase => "https://files.stripe.com";

        /// <summary>Default base URL for Stripe's Meter Events API.</summary>
        public static string DefaultMeterEventsBase => "https://meter-events.stripe.com";

        /// <summary>Gets the base URL for Stripe's API.</summary>
        /// <value>The base URL for Stripe's API.</value>
        public override string ApiBase { get; }

        /// <summary>Gets the API key used by the client to send requests.</summary>
        /// <value>The API key used by the client to send requests.</value>
        public override string ApiKey { get; }

        /// <summary>Gets the client ID used by the client in OAuth requests.</summary>
        /// <value>The client ID used by the client in OAuth requests.</value>
        public override string ClientId { get; }

        /// <summary>Gets the base URL for Stripe's OAuth API.</summary>
        /// <value>The base URL for Stripe's OAuth API.</value>
        public override string ConnectBase { get; }

        /// <summary>Gets the base URL for Stripe's Files API.</summary>
        /// <value>The base URL for Stripe's Files API.</value>
        public override string FilesBase { get; }

        /// <summary>Gets the base URL for Stripe's Meter Events API.</summary>
        /// <value>The base URL for Stripe's Meter Events API.</value>
        public override string MeterEventsBase { get; }

        /// <summary>Gets the <see cref="IHttpClient"/> used to send HTTP requests.</summary>
        /// <value>The <see cref="IHttpClient"/> used to send HTTP requests.</value>
        public override IHttpClient HttpClient { get; }

        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <typeparam name="T">Type of the Stripe entity returned by the API.</typeparam>
        /// <param name="baseAddress">The base address of the request.</param>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="options">The parameters of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public override async Task<T> RequestAsync<T>(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            var apiMode = ApiModeUtils.GetApiMode(path);
            var request = this.MakeStripeRequest(baseAddress, method, path, options, requestOptions, apiMode);
            var response = await this.HttpClient.MakeRequestAsync(request, cancellationToken)
                .ConfigureAwait(false);

            return this.ProcessResponse<T>(response, apiMode);
        }

        public override async Task<Stream> RequestStreamingAsync(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            var apiMode = ApiModeUtils.GetApiMode(path);
            var request = this.MakeStripeRequest(baseAddress, method, path, options, requestOptions, apiMode);
            var response = await this.HttpClient.MakeStreamingRequestAsync(request, cancellationToken)
                .ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Body;
            }

            var readResponse = await response.ToStripeResponseAsync().ConfigureAwait(false);
            throw BuildStripeException(readResponse);
        }

        private static IHttpClient BuildDefaultHttpClient()
        {
            return new SystemNetHttpClient();
        }

        private static StripeException BuildV2StripeException(StripeResponse response)
        {
            JObject jObject = null;

            try
            {
                jObject = JObject.Parse(response.Content);
            }
            catch (Newtonsoft.Json.JsonException)
            {
                return BuildInvalidResponseException(response);
            }

            JToken error = (JToken)jObject["error"];
            string type = (string)error["type"];
            return StripeException.ParseV2Exception(
                    type,
                    response,
                    error) ?? BuildStripeException(response);
        }

        private static StripeException BuildStripeException(StripeResponse response)
        {
            JObject jObject = null;

            try
            {
                jObject = JObject.Parse(response.Content);
            }
            catch (Newtonsoft.Json.JsonException)
            {
                return BuildInvalidResponseException(response);
            }

            // If the value of the `error` key is a string, then the error is an OAuth error
            // and we instantiate the StripeError object with the entire JSON.
            // Otherwise, it's a regular API error and we instantiate the StripeError object
            // with just the nested hash contained in the `error` key.
            var errorToken = jObject["error"];
            if (errorToken == null)
            {
                return BuildInvalidResponseException(response);
            }

            var stripeError = errorToken.Type == JTokenType.String
                ? StripeError.FromJson(response.Content)
                : StripeError.FromJson(errorToken.ToString());

            stripeError.StripeResponse = response;

            return new StripeException(
                response.StatusCode,
                stripeError,
                stripeError.Message ?? stripeError.ErrorDescription)
            {
                StripeResponse = response,
            };
        }

        private static StripeException BuildInvalidResponseException(StripeResponse response)
        {
            return new StripeException(
                response.StatusCode,
                null,
                $"Invalid response object from API: \"{response.Content}\"")
            {
                StripeResponse = response,
            };
        }

        // Note: BaseOptions options really means query params here
        private StripeRequest MakeStripeRequest(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            ApiMode apiMode)
        {
            if (this.defaultUsage.Count > 0)
            {
                var usage = this.defaultUsage;
                if (requestOptions?.Usage?.Count > 0)
                {
                    usage = usage.Concat(requestOptions.Usage).ToList();
                }

                requestOptions = requestOptions.WithUsage(usage);
            }

            var uri = StripeRequest.BuildUri(
                requestOptions?.BaseUrl ?? this.GetBaseUrl(baseAddress),
                method,
                path,
                options,
                apiMode);

            return new StripeRequest(
                method,
                uri,
                requestOptions.WithClientOptions(this.clientOptions),
                options,
                null,
                apiMode);
        }

        private T ProcessResponse<T>(StripeResponse response, ApiMode apiMode)
            where T : IStripeEntity
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (apiMode == ApiMode.V2)
                {
                    throw BuildV2StripeException(response);
                }

                throw BuildStripeException(response);
            }

            T obj;
            try
            {
                obj = StripeEntity.FromJson<T>(response.Content, this.jsonSerializerSettings);
            }
            catch (Newtonsoft.Json.JsonException)
            {
                throw BuildInvalidResponseException(response);
            }

            obj.StripeResponse = response;

            return obj;
        }

        /// <summary>Sends a request to Stripe's API as a synchronous operation.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <returns>The response as a StripeResponse.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public override StripeResponse RawRequest(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null)
        {
            return this.RawRequestAsync(method, path, content, requestOptions)
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public override async Task<StripeResponse> RawRequestAsync(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            if (method != HttpMethod.Post && content != null)
            {
                throw new InvalidOperationException("content is not allowed for non-POST requests.");
            }

            requestOptions = requestOptions.WithUsage(this.defaultUsage.Concat(RawRequestUsage).ToList());
            var apiMode = ApiModeUtils.GetApiMode(path);
            var uri = StripeRequest.BuildUri(
                requestOptions?.BaseUrl ?? this.GetBaseUrl(BaseAddress.Api),
                method,
                path,
                null,
                apiMode);

            var request = StripeRequest.CreateWithStringContent(method, uri, content, requestOptions.WithClientOptions(this.clientOptions), apiMode);

            var response = await this.HttpClient.MakeRequestAsync(request, cancellationToken)
                    .ConfigureAwait(false);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw BuildStripeException(response);
            }

            return response;
        }
    }
}

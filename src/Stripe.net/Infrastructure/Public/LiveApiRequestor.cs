namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.IO;
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

        public LiveApiRequestor(
            string apiKey = null,
            string clientId = null,
            IHttpClient httpClient = null,
            string apiBase = null,
            string connectBase = null,
            string filesBase = null,
            string eventsBase = null)
        {
            if (apiKey != null && apiKey.Length == 0)
            {
                throw new ArgumentException("API key cannot be the empty string.", nameof(apiKey));
            }

            if (apiKey != null && StringUtils.ContainsWhitespace(apiKey))
            {
                throw new ArgumentException("API key cannot contain whitespace.", nameof(apiKey));
            }

            this.ApiKey = apiKey;
            this.ClientId = clientId;
            this.HttpClient = httpClient ?? BuildDefaultHttpClient();
            this.ApiBase = apiBase ?? DefaultApiBase;
            this.ConnectBase = connectBase ?? DefaultConnectBase;
            this.FilesBase = filesBase ?? DefaultFilesBase;
            this.EventsBase = eventsBase ?? DefaultEventsBase;
            this.jsonSerializerSettings = StripeConfiguration.DefaultSerializerSettings(this);
        }

        /// <summary>Default base URL for Stripe's API.</summary>
        public static string DefaultApiBase => "https://api.stripe.com";

        /// <summary>Default base URL for Stripe's OAuth API.</summary>
        public static string DefaultConnectBase => "https://connect.stripe.com";

        /// <summary>Default base URL for Stripe's Files API.</summary>
        public static string DefaultFilesBase => "https://files.stripe.com";

        /// <summary>Default base URL for Stripe's Events API.</summary>
        public static string DefaultEventsBase => "https://events.stripe.com";

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

        /// <summary>Gets the base URL for Stripe's Events API.</summary>
        /// <value>The base URL for Stripe's Events API.</value>
        public override string EventsBase { get; }

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
            var uri = StripeRequest.BuildUri(
                this.GetBaseUrl(baseAddress),
                method,
                path,
                options,
                apiMode);

            var request = new StripeRequest(
                method,
                uri,
                requestOptions?.ApiKey ?? this.ApiKey,
                options,
                null,
                requestOptions,
                apiMode);

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
            var uri = StripeRequest.BuildUri(
                this.GetBaseUrl(baseAddress),
                method,
                path,
                options,
                apiMode);

            var request = new StripeRequest(
                method,
                uri,
                requestOptions?.ApiKey ?? this.ApiKey,
                options,
                null,
                requestOptions,
                apiMode);

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

        private string GetBaseUrl(BaseAddress baseAddress)
        {
            switch (baseAddress)
            {
                case BaseAddress.Api:
                    return this.ApiBase;
                case BaseAddress.Files:
                    return this.FilesBase;
                case BaseAddress.Connect:
                    return this.ConnectBase;
                case BaseAddress.Events:
                    return this.EventsBase;
                default:
                    throw new ArgumentOutOfRangeException(nameof(baseAddress), baseAddress, null);
            }
        }

        /// <summary>Sends a request to Stripe's API as a synchronous operation.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The response as a StripeResponse.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public override StripeResponse RawRequest(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            return this.RawRequestAsync(method, path, content, requestOptions, cancellationToken)
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

            requestOptions = requestOptions.WithUsage(RawRequestUsage);
            var apiMode = requestOptions?.ApiMode ?? ApiMode.V1;
            var uri = StripeRequest.BuildUri(
                requestOptions?.BaseUrl ?? this.GetBaseUrl(BaseAddress.Api),
                method,
                path,
                null,
                apiMode);

            var request = StripeRequest.CreateWithStringContent(this.ApiKey, method, uri, content, requestOptions, apiMode);

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

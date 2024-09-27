namespace Stripe
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Stripe client, used to issue requests to Stripe's API and deserialize responses.
    /// </summary>
    public class StripeClient : IStripeClient
    {
        private JsonSerializerSettings jsonSerializerSettings;

        // Fields: The beginning of the section generated from our OpenAPI spec
        private V1Services v1;
        private V2Services v2;

        // Fields: The end of the section generated from our OpenAPI spec
        internal StripeClient(ApiRequestor requestor)
        {
            this.Requestor = requestor;
            this.jsonSerializerSettings = StripeConfiguration.DefaultSerializerSettings(requestor);
        }

        /// <summary>Initializes a new instance of the <see cref="StripeClient"/> class.</summary>
        /// <param name="apiKey">The API key used by the client to make requests.</param>
        /// <param name="clientId">The client ID used by the client in OAuth requests.</param>
        /// <param name="httpClient">
        /// The <see cref="IHttpClient"/> client to use. If <c>null</c>, an HTTP client will be
        /// created with default parameters.
        /// </param>
        /// <param name="apiBase">
        /// The base URL for Stripe's API. Defaults to <see cref="DefaultApiBase"/>.
        /// </param>
        /// <param name="connectBase">
        /// The base URL for Stripe's OAuth API. Defaults to <see cref="DefaultConnectBase"/>.
        /// </param>
        /// <param name="filesBase">
        /// The base URL for Stripe's Files API. Defaults to <see cref="DefaultFilesBase"/>.
        /// </param>
        /// <param name="meterEventsBase">
        /// The base URL for Stripe's Meter Events API. Defaults to <see cref="DefaultMeterEventsBase"/>.
        /// </param>
        /// <exception cref="ArgumentNullException">if <c>apiKey</c> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">
        /// if <c>apiKey</c> is empty or contains whitespace.
        /// </exception>
        public StripeClient(
            string apiKey = null,
            string clientId = null,
            IHttpClient httpClient = null,
            string apiBase = null,
            string connectBase = null,
            string filesBase = null,
            string meterEventsBase = null)
            : this(new StripeClientOptions
            {
                ApiKey = apiKey,
                ClientId = clientId,
                HttpClient = httpClient,
                ApiBase = apiBase,
                ConnectBase = connectBase,
                FilesBase = filesBase,
                MeterEventsBase = meterEventsBase,
            })
        {
        }

        public StripeClient(StripeClientOptions options)
            : this(new LiveApiRequestor(options))
        {
        }

        /// <summary>Default base URL for Stripe's API.</summary>
        public static string DefaultApiBase => "https://api.stripe.com";

        /// <summary>Default base URL for Stripe's OAuth API.</summary>
        public static string DefaultConnectBase => "https://connect.stripe.com";

        /// <summary>Default base URL for Stripe's Files API.</summary>
        public static string DefaultFilesBase => "https://files.stripe.com";

        /// <summary>Default base URL for Stripe's Meter Events API.</summary>
        public static string DefaultMeterEventsBase => "https://meter-events.stripe.com";

        internal ApiRequestor Requestor { get; }

        /// <summary>Gets the base URL for Stripe's API.</summary>
        /// <value>The base URL for Stripe's API.</value>
        public string ApiBase => this.Requestor?.ApiBase;

        /// <summary>Gets the API key used by the client to send requests.</summary>
        /// <value>The API key used by the client to send requests.</value>
        public string ApiKey => this.Requestor?.ApiKey;

        /// <summary>Gets the client ID used by the client in OAuth requests.</summary>
        /// <value>The client ID used by the client in OAuth requests.</value>
        public string ClientId => this.Requestor?.ClientId;

        /// <summary>Gets the base URL for Stripe's OAuth API.</summary>
        /// <value>The base URL for Stripe's OAuth API.</value>
        public string ConnectBase => this.Requestor?.ConnectBase;

        /// <summary>Gets the base URL for Stripe's Files API.</summary>
        /// <value>The base URL for Stripe's Files API.</value>
        public string FilesBase => this.Requestor?.FilesBase;

        /// <summary>Gets the base URL for Stripe's Meter Events API.</summary>
        /// <value>The base URL for Stripe's Meter Events API.</value>
        public string MeterEventsBase => this.Requestor?.MeterEventsBase;

        /// <summary>Gets the <see cref="IHttpClient"/> used to send HTTP requests.</summary>
        /// <value>The <see cref="IHttpClient"/> used to send HTTP requests.</value>
        public IHttpClient HttpClient => this.Requestor?.HttpClient;

        // Properties: The beginning of the section generated from our OpenAPI spec
        public virtual V1Services V1 => this.v1 ??= new V1Services(this.Requestor);

        public virtual V2Services V2 => this.v2 ??= new V2Services(this.Requestor);

        // Properties: The end of the section generated from our OpenAPI spec

        /// <summary>Deserializes a JSON string into a Stripe object.</summary>
        /// <typeparam name="T">The type of the Stripe object to deserialize to.</typeparam>
        /// <param name="response">The HTTP response as a StripeResponse.</param>
        /// <returns>The deserialized Stripe object from the JSON string.</returns>
        public T Deserialize<T>(string response)
            where T : IStripeEntity
        {
            return StripeEntity.FromJson<T>(response);
        }

        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <typeparam name="T">Type of the Stripe entity returned by the API.</typeparam>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="options">The parameters of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public async Task<T> RequestAsync<T>(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            return await this.Requestor.RequestAsync<T>(BaseAddress.Api, method, path, options, requestOptions, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<Stream> RequestStreamingAsync(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            return await this.Requestor.RequestStreamingAsync(BaseAddress.Api, method, path, options, requestOptions, cancellationToken);
        }

        /// <summary>Sends a request to Stripe's API as a synchronous operation.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The response as a StripeResponse.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public StripeResponse RawRequest(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            return this.Requestor.RawRequest(method, path, content, requestOptions, cancellationToken);
        }

        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public async Task<StripeResponse> RawRequestAsync(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            return await this.Requestor.RawRequestAsync(method, path, content, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Parses a JSON string from a Stripe webhook into a <see cref="ThinEvent"/> object, while
        /// verifying the <a href="https://stripe.com/docs/webhooks/signatures">webhook's
        /// signature</a>.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="stripeSignatureHeader">
        /// The value of the <c>Stripe-Signature</c> header from the webhook request.
        /// </param>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="tolerance">The time tolerance, in seconds (default 300).</param>
        /// <returns>The deserialized <see cref="ThinEvent"/>.</returns>
        /// <exception cref="StripeException">
        /// Thrown if the signature verification fails for any reason, of if the API version of the
        /// event doesn't match Stripe.net's default API version.
        /// </exception>
        public ThinEvent ParseThinEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance = EventUtility.DefaultTimeTolerance)
        {
            EventUtility.ValidateSignature(json, stripeSignatureHeader, secret, tolerance, DateTimeOffset.UtcNow.ToUnixTimeSeconds());

            var thinEvent = JsonUtils.DeserializeObject<ThinEvent>(json, this.jsonSerializerSettings);

            return thinEvent;
        }

        /// <summary>
        /// Parses a JSON string from a Stripe webhook into a <see cref="Event"/> object, while
        /// verifying the <a href="https://stripe.com/docs/webhooks/signatures">webhook's
        /// signature</a>.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="stripeSignatureHeader">
        /// The value of the <c>Stripe-Signature</c> header from the webhook request.
        /// </param>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="tolerance">The time tolerance, in seconds (default 300).</param>
        /// <returns>The deserialized <see cref="Event"/>.</returns>
        /// <exception cref="StripeException">
        /// Thrown if the signature verification fails for any reason, of if the API version of the
        /// event doesn't match Stripe.net's default API version.
        /// </exception>
        public Event ParseSnapshotEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance = EventUtility.DefaultTimeTolerance)
        {
            EventUtility.ValidateSignature(json, stripeSignatureHeader, secret, tolerance, DateTimeOffset.UtcNow.ToUnixTimeSeconds());

            var stripeEvent = JsonUtils.DeserializeObject<Event>(
                json,
                StripeConfiguration.SerializerSettings);

            return stripeEvent;
        }
    }
}

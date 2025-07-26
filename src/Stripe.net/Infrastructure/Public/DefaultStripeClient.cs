namespace Stripe
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// A default implementation of the <see cref="IStripeClient"/> interface.  This is used by
    /// StripeConfiguration to provide a default client, which is used in conjuction with Service
    /// instances when no client is provided.
    /// </summary>
    internal class DefaultStripeClient : IStripeClient
    {
        public DefaultStripeClient(string apiKey, string clientId, IHttpClient httpClient)
        {
            this.Requestor = new LiveApiRequestor(
                new StripeClientOptions
                {
                    ApiKey = apiKey,
                    ClientId = clientId,
                    HttpClient = httpClient,
                }, new List<string>());
        }

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

        internal ApiRequestor Requestor { get; }

        /// <inheritdoc/>
        public async Task<T> RequestAsync<T>(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            return await this.Requestor.RequestAsync<T>(BaseAddress.Api, method, path, options, requestOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Stream> RequestStreamingAsync(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            return await this.Requestor.RequestStreamingAsync(BaseAddress.Api, method, path, options, requestOptions, cancellationToken).ConfigureAwait(false);
        }
    }
}

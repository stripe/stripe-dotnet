namespace Stripe
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// An ApiRequestor used to issue requests to Stripe's API and deserialize responses. See LiveApiRequestor and ApiRequestorAdapter for implementations.
    /// </summary>
    internal abstract class ApiRequestor
    {
        /// <summary>Gets the base URL for Stripe's API.</summary>
        /// <value>The base URL for Stripe's API.</value>
        public virtual string ApiBase { get; }

        /// <summary>Gets the base URL for Stripe's Files API.</summary>
        /// <value>The base URL for Stripe's Files API.</value>
        public virtual string FilesBase { get; }

        /// <summary>Gets the base URL for Stripe's OAuth API.</summary>
        /// <value>The base URL for Stripe's OAuth API.</value>
        public virtual string ConnectBase { get; }

        /// <summary>Gets the base URL for Stripe's Meter Events API.</summary>
        /// <value>The base URL for Stripe's Meter Events API.</value>
        public virtual string MeterEventsBase { get; }

        /// <summary>Gets the API key used by the client to send requests.</summary>
        /// <value>The API key used by the client to send requests.</value>
        public virtual string ApiKey { get; }

        /// <summary>Gets the client ID used by the client in OAuth requests.</summary>
        /// <value>The client ID used by the client in OAuth requests.</value>
        public virtual string ClientId { get; }

        /// <summary>Gets the <see cref="IHttpClient"/> used to send HTTP requests.</summary>
        /// <value>The <see cref="IHttpClient"/> used to send HTTP requests.</value>
        public virtual IHttpClient HttpClient { get; }

        internal string GetBaseUrl(BaseAddress baseAddress)
        {
            switch (baseAddress)
            {
                case BaseAddress.Api:
                    return this.ApiBase;
                case BaseAddress.Files:
                    return this.FilesBase;
                case BaseAddress.Connect:
                    return this.ConnectBase;
                case BaseAddress.MeterEvents:
                    return this.MeterEventsBase;
                default:
                    throw new ArgumentOutOfRangeException(nameof(baseAddress), baseAddress, null);
            }
        }

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
        public abstract Task<T> RequestAsync<T>(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : IStripeEntity;

        public abstract Task<Stream> RequestStreamingAsync(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default);

        public abstract StripeResponse RawRequest(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null);

        public abstract Task<StripeResponse> RawRequestAsync(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default);
    }
}

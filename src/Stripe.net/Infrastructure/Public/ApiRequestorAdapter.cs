namespace Stripe
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Wraps an IStripeClient but implements the ApiRequestor abstract class. We need this so that the Service class can use an ApiRequestor consistently, but can be constructable with an IStripeClient, which is a public interface we need to preserve for backwards compatibility. </summary>
    internal class ApiRequestorAdapter : ApiRequestor
    {
        private IStripeClient client;

        public ApiRequestorAdapter(IStripeClient client)
        {
            this.client = client;
        }

        public override string ApiBase => this.client.ApiBase;

        public override string ApiKey => this.client.ApiKey;

        public override string ClientId => this.client.ClientId;

        public override string ConnectBase => this.client.ConnectBase;

        public override string FilesBase => this.client.FilesBase;

        public override string MeterEventsBase => this.client.MeterEventsBase;

        internal static ApiRequestor Adapt(IStripeClient client)
        {
            if (client is StripeClient stripeClient)
            {
                return stripeClient.Requestor;
            }

            return new ApiRequestorAdapter(client);
        }

        public override Task<T> RequestAsync<T>(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            if (baseAddress != BaseAddress.Api)
            {
                requestOptions ??= new RequestOptions();
                requestOptions.BaseUrl = this.GetBaseUrl(baseAddress);
            }

            return this.client.RequestAsync<T>(method, path, options, requestOptions, cancellationToken);
        }

        public override Task<Stream> RequestStreamingAsync(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            return this.client.RequestStreamingAsync(method, path, options, requestOptions, cancellationToken);
        }

        public override StripeResponse RawRequest(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null)
        {
            throw new System.NotImplementedException("RawRequest is unimplemented for this ApiRequestor");
        }

        public override Task<StripeResponse> RawRequestAsync(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException("RawRequestAsync is unimplemented for this ApiRequestor");
        }
    }
}

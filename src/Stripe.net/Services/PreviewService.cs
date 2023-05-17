namespace Stripe.Services
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PreviewService
    {
        private readonly StripeClient client;

        internal PreviewService(StripeClient client)
        {
            this.client = client;
        }

        public StripeResponse Get(string path, RawRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetAsync(path, requestOptions, cancellationToken)
                .GetAwaiter().GetResult();
        }

        public Task<StripeResponse> GetAsync(string path, RawRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.client.RawRequestAsync(HttpMethod.Get, path, null, BuildPreviewOptions(requestOptions), cancellationToken);
        }

        public StripeResponse Post(string path, string body, RawRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.PostAsync(path, body, requestOptions, cancellationToken)
                .GetAwaiter().GetResult();
        }

        public Task<StripeResponse> PostAsync(string path, string body, RawRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.client.RawRequestAsync(HttpMethod.Post, path, body, BuildPreviewOptions(requestOptions), cancellationToken);
        }

        public StripeResponse Delete(string path, RawRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteAsync(path, requestOptions, cancellationToken)
                .GetAwaiter().GetResult();
        }

        public Task<StripeResponse> DeleteAsync(string path, RawRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.client.RawRequestAsync(HttpMethod.Delete, path, null, BuildPreviewOptions(requestOptions), cancellationToken);
        }

        private static RawRequestOptions BuildPreviewOptions(RawRequestOptions requestOptions)
        {
            RawRequestOptions cloned = requestOptions != null ? (RawRequestOptions)requestOptions.Clone() : new RawRequestOptions();
            cloned.ApiMode = ApiMode.Preview;
            return cloned;
        }
    }
}
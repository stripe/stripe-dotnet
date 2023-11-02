// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConfirmationTokenService : Service<ConfirmationToken>,
        IRetrievable<ConfirmationToken, ConfirmationTokenGetOptions>
    {
        public ConfirmationTokenService()
            : base(null)
        {
        }

        public ConfirmationTokenService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/confirmation_tokens";

        public virtual ConfirmationToken Get(string id, ConfirmationTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ConfirmationToken>(HttpMethod.Get, $"/v1/confirmation_tokens/{id}", options, requestOptions);
        }

        public virtual Task<ConfirmationToken> GetAsync(string id, ConfirmationTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConfirmationToken>(HttpMethod.Get, $"/v1/confirmation_tokens/{id}", options, requestOptions, cancellationToken);
        }
    }
}

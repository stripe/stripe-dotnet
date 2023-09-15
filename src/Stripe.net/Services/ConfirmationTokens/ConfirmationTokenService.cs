// File generated from our OpenAPI spec
namespace Stripe
{
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
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ConfirmationToken> GetAsync(string id, ConfirmationTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

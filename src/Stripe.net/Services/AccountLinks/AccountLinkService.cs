// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountLinkService : Service<AccountLink>,
        ICreatable<AccountLink, AccountLinkCreateOptions>
    {
        public AccountLinkService()
            : base(null)
        {
        }

        public AccountLinkService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/account_links";

        public virtual AccountLink Create(AccountLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<AccountLink> CreateAsync(AccountLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}

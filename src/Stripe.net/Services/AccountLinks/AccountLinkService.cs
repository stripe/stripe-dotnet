// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
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
            return this.Request<AccountLink>(HttpMethod.Post, $"/v1/account_links", options, requestOptions);
        }

        public virtual Task<AccountLink> CreateAsync(AccountLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountLink>(HttpMethod.Post, $"/v1/account_links", options, requestOptions, cancellationToken);
        }
    }
}

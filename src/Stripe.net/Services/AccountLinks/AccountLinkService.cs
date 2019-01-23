namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class AccountLinkService : Service<AccountLink>,
        ICreatable<AccountLink, AccountLinkCreateOptions>
    {
        public AccountLinkService()
            : base(null)
        {
        }

        public AccountLinkService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/account_links";

        public virtual AccountLink Create(AccountLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<AccountLink> CreateAsync(AccountLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}

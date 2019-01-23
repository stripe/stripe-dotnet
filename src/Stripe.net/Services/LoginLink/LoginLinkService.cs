namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class LoginLinkService : ServiceNested<LoginLink>,
        INestedCreatable<LoginLink, LoginLinkCreateOptions>
    {
        public LoginLinkService()
            : base(null)
        {
        }

        public LoginLinkService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/login_links";

        public virtual LoginLink Create(string accountId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(accountId, options, requestOptions);
        }

        public virtual Task<LoginLink> CreateAsync(string accountId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(accountId, options, requestOptions, cancellationToken);
        }
    }
}

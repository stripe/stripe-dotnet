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

        public LoginLinkService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/login_links";

        public virtual LoginLink Create(string id, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(id, options, requestOptions);
        }

        public virtual Task<LoginLink> CreateAsync(string id, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

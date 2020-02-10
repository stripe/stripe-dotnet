namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        public virtual LoginLink Create(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<LoginLink> CreateAsync(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}

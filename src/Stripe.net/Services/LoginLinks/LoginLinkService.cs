// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LoginLinkService : ServiceNested<LoginLink>,
        INestedCreatable<LoginLink, LoginLinkCreateOptions>
    {
        public LoginLinkService()
        {
        }

        public LoginLinkService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/accounts/{PARENT_ID}/login_links";

        /// <summary>
        /// <p>Creates a single-use login link for an Express account to access their Stripe
        /// dashboard.</p>.
        ///
        /// <p><strong>You may only create login links for <a
        /// href="https://stripe.com/docs/connect/express-accounts">Express accounts</a> connected
        /// to your platform</strong>.</p>.
        /// </summary>
        public virtual LoginLink Create(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<LoginLink>(HttpMethod.Post, $"/v1/accounts/{parentId}/login_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a single-use login link for an Express account to access their Stripe
        /// dashboard.</p>.
        ///
        /// <p><strong>You may only create login links for <a
        /// href="https://stripe.com/docs/connect/express-accounts">Express accounts</a> connected
        /// to your platform</strong>.</p>.
        /// </summary>
        public virtual Task<LoginLink> CreateAsync(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LoginLink>(HttpMethod.Post, $"/v1/accounts/{parentId}/login_links", options, requestOptions, cancellationToken);
        }
    }
}

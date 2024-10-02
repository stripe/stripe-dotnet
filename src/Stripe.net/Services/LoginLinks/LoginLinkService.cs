// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
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
        /// <p>Creates a single-use login link for a connected account to access the Express
        /// Dashboard.</p>.
        ///
        /// <p><strong>You can only create login links for accounts that use the <a
        /// href="https://stripe.com/connect/express-dashboard">Express Dashboard</a> and are
        /// connected to your platform</strong>.</p>.
        /// </summary>
        public virtual LoginLink Create(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<LoginLink>(HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/login_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a single-use login link for a connected account to access the Express
        /// Dashboard.</p>.
        ///
        /// <p><strong>You can only create login links for accounts that use the <a
        /// href="https://stripe.com/connect/express-dashboard">Express Dashboard</a> and are
        /// connected to your platform</strong>.</p>.
        /// </summary>
        public virtual Task<LoginLink> CreateAsync(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LoginLink>(HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/login_links", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountLoginLinkService : ServiceNested<LoginLink>,
        INestedCreatable<LoginLink, AccountLoginLinkCreateOptions>
    {
        public AccountLoginLinkService()
        {
        }

        internal AccountLoginLinkService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountLoginLinkService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a single-use login link for a connected account to access the Express
        /// Dashboard.</p>.
        ///
        /// <p><strong>You can only create login links for accounts that use the <a
        /// href="https://stripe.com/connect/express-dashboard">Express Dashboard</a> and are
        /// connected to your platform</strong>.</p>.
        /// </summary>
        public virtual LoginLink Create(string parentId, AccountLoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<LoginLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/login_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a single-use login link for a connected account to access the Express
        /// Dashboard.</p>.
        ///
        /// <p><strong>You can only create login links for accounts that use the <a
        /// href="https://stripe.com/connect/express-dashboard">Express Dashboard</a> and are
        /// connected to your platform</strong>.</p>.
        /// </summary>
        public virtual Task<LoginLink> CreateAsync(string parentId, AccountLoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LoginLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/login_links", options, requestOptions, cancellationToken);
        }
    }
}

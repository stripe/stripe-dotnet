// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountSessionService : Service
    {
        internal AccountSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create an Account Session.
        /// </summary>
        public virtual AccountSessionResource Create(AccountSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountSessionResource>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_sessions", options, requestOptions);
        }

        /// <summary>
        /// Create an Account Session.
        /// </summary>
        public virtual Task<AccountSessionResource> CreateAsync(AccountSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountSessionResource>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_sessions", options, requestOptions, cancellationToken);
        }
    }
}

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
        public virtual AccountSession Create(AccountSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_sessions", options, requestOptions);
        }

        /// <summary>
        /// Create an Account Session.
        /// </summary>
        public virtual Task<AccountSession> CreateAsync(AccountSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_sessions", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountSessionService : Service<AccountSession>,
        ICreatable<AccountSession, AccountSessionCreateOptions>
    {
        public AccountSessionService()
        {
        }

        public AccountSessionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/account_sessions";

        /// <summary>
        /// <p>Creates a AccountSession object that includes a single-use token that the platform
        /// can use on their front-end to grant client-side API access.</p>.
        /// </summary>
        public virtual AccountSession Create(AccountSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountSession>(HttpMethod.Post, $"/v1/account_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a AccountSession object that includes a single-use token that the platform
        /// can use on their front-end to grant client-side API access.</p>.
        /// </summary>
        public virtual Task<AccountSession> CreateAsync(AccountSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountSession>(HttpMethod.Post, $"/v1/account_sessions", options, requestOptions, cancellationToken);
        }
    }
}

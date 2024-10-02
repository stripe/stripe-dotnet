// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountLinkService : Service<AccountLink>,
        ICreatable<AccountLink, AccountLinkCreateOptions>
    {
        public AccountLinkService()
        {
        }

        public AccountLinkService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/account_links";

        /// <summary>
        /// <p>Creates an AccountLink object that includes a single-use Stripe URL that the platform
        /// can redirect their user to in order to take them through the Connect Onboarding
        /// flow.</p>.
        /// </summary>
        public virtual AccountLink Create(AccountLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountLink>(HttpMethod.Post, $"/v1/account_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an AccountLink object that includes a single-use Stripe URL that the platform
        /// can redirect their user to in order to take them through the Connect Onboarding
        /// flow.</p>.
        /// </summary>
        public virtual Task<AccountLink> CreateAsync(AccountLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountLink>(HttpMethod.Post, $"/v1/account_links", options, requestOptions, cancellationToken);
        }
    }
}

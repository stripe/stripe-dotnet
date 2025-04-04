// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountLinkService : Service,
        ICreatable<AccountLink, AccountLinkCreateOptions>
    {
        public AccountLinkService()
        {
        }

        internal AccountLinkService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountLinkService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates an AccountLink object that includes a single-use Stripe URL that the platform
        /// can redirect their user to in order to take them through the Connect Onboarding
        /// flow.</p>.
        /// </summary>
        public virtual AccountLink Create(AccountLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/account_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an AccountLink object that includes a single-use Stripe URL that the platform
        /// can redirect their user to in order to take them through the Connect Onboarding
        /// flow.</p>.
        /// </summary>
        public virtual Task<AccountLink> CreateAsync(AccountLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/account_links", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountLinkService : Service
    {
        internal AccountLinkService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountLinkService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates an AccountLink object that includes a single-use Stripe URL that the merchant
        /// can redirect their user to in order to take them to a Stripe-hosted application such as
        /// Recipient Onboarding.
        /// </summary>
        public virtual AccountLink Create(AccountLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountLink>(BaseAddress.Api, HttpMethod.Post, $"/v2/account_links", options, requestOptions);
        }

        /// <summary>
        /// Creates an AccountLink object that includes a single-use Stripe URL that the merchant
        /// can redirect their user to in order to take them to a Stripe-hosted application such as
        /// Recipient Onboarding.
        /// </summary>
        public virtual Task<AccountLink> CreateAsync(AccountLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountLink>(BaseAddress.Api, HttpMethod.Post, $"/v2/account_links", options, requestOptions, cancellationToken);
        }
    }
}

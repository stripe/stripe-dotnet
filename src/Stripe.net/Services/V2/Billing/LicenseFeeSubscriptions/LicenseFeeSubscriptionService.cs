// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LicenseFeeSubscriptionService : Service
    {
        internal LicenseFeeSubscriptionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal LicenseFeeSubscriptionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a License Fee Subscription object.
        /// </summary>
        public virtual LicenseFeeSubscription Get(string id, LicenseFeeSubscriptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<LicenseFeeSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fee_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a License Fee Subscription object.
        /// </summary>
        public virtual Task<LicenseFeeSubscription> GetAsync(string id, LicenseFeeSubscriptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LicenseFeeSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fee_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

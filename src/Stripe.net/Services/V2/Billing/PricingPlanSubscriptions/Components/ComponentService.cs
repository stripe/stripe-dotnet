// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlanSubscriptions
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ComponentService : Service
    {
        internal ComponentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ComponentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a Pricing Plan Subscription's components.
        /// </summary>
        public virtual V2.Billing.PricingPlanSubscriptionComponents Get(string id, ComponentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.PricingPlanSubscriptionComponents>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plan_subscriptions/{WebUtility.UrlEncode(id)}/components", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Pricing Plan Subscription's components.
        /// </summary>
        public virtual Task<V2.Billing.PricingPlanSubscriptionComponents> GetAsync(string id, ComponentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.PricingPlanSubscriptionComponents>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plan_subscriptions/{WebUtility.UrlEncode(id)}/components", options, requestOptions, cancellationToken);
        }
    }
}

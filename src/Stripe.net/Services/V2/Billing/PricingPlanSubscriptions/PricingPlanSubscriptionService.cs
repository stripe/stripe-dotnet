// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PricingPlanSubscriptionService : Service
    {
        private V2.Billing.PricingPlanSubscriptions.ComponentService components;

        internal PricingPlanSubscriptionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PricingPlanSubscriptionService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.PricingPlanSubscriptions.ComponentService Components => this.components ??= new V2.Billing.PricingPlanSubscriptions.ComponentService(
            this.Requestor);

        /// <summary>
        /// Retrieve a Pricing Plan Subscription object.
        /// </summary>
        public virtual PricingPlanSubscription Get(string id, PricingPlanSubscriptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PricingPlanSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plan_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Pricing Plan Subscription object.
        /// </summary>
        public virtual Task<PricingPlanSubscription> GetAsync(string id, PricingPlanSubscriptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PricingPlanSubscription>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plan_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Pricing Plan Subscription objects.
        /// </summary>
        public virtual V2.StripeList<PricingPlanSubscription> List(PricingPlanSubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<PricingPlanSubscription>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plan_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// List all Pricing Plan Subscription objects.
        /// </summary>
        public virtual Task<V2.StripeList<PricingPlanSubscription>> ListAsync(PricingPlanSubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<PricingPlanSubscription>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plan_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Pricing Plan Subscription objects.
        /// </summary>
        public virtual IEnumerable<PricingPlanSubscription> ListAutoPaging(PricingPlanSubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PricingPlanSubscription>($"/v2/billing/pricing_plan_subscriptions", options, requestOptions);
        }

        /// <summary>
        /// List all Pricing Plan Subscription objects.
        /// </summary>
        public virtual IAsyncEnumerable<PricingPlanSubscription> ListAutoPagingAsync(PricingPlanSubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PricingPlanSubscription>($"/v2/billing/pricing_plan_subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Pricing Plan Subscription object.
        /// </summary>
        public virtual PricingPlanSubscription Update(string id, PricingPlanSubscriptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PricingPlanSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plan_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Pricing Plan Subscription object.
        /// </summary>
        public virtual Task<PricingPlanSubscription> UpdateAsync(string id, PricingPlanSubscriptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PricingPlanSubscription>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plan_subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

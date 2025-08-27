// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PricingPlanService : Service
    {
        private V2.Billing.PricingPlans.ComponentService components;
        private V2.Billing.PricingPlans.VersionService versions;

        internal PricingPlanService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PricingPlanService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.PricingPlans.ComponentService Components => this.components ??= new V2.Billing.PricingPlans.ComponentService(
            this.Requestor);

        public virtual V2.Billing.PricingPlans.VersionService Versions => this.versions ??= new V2.Billing.PricingPlans.VersionService(
            this.Requestor);

        /// <summary>
        /// Create a Pricing Plan object.
        /// </summary>
        public virtual PricingPlan Create(PricingPlanCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PricingPlan>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans", options, requestOptions);
        }

        /// <summary>
        /// Create a Pricing Plan object.
        /// </summary>
        public virtual Task<PricingPlan> CreateAsync(PricingPlanCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PricingPlan>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Pricing Plan object.
        /// </summary>
        public virtual PricingPlan Get(string id, PricingPlanGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PricingPlan>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Pricing Plan object.
        /// </summary>
        public virtual Task<PricingPlan> GetAsync(string id, PricingPlanGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PricingPlan>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Pricing Plan objects.
        /// </summary>
        public virtual V2.StripeList<PricingPlan> List(PricingPlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<PricingPlan>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans", options, requestOptions);
        }

        /// <summary>
        /// List all Pricing Plan objects.
        /// </summary>
        public virtual Task<V2.StripeList<PricingPlan>> ListAsync(PricingPlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<PricingPlan>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Pricing Plan objects.
        /// </summary>
        public virtual IEnumerable<PricingPlan> ListAutoPaging(PricingPlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PricingPlan>($"/v2/billing/pricing_plans", options, requestOptions);
        }

        /// <summary>
        /// List all Pricing Plan objects.
        /// </summary>
        public virtual IAsyncEnumerable<PricingPlan> ListAutoPagingAsync(PricingPlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PricingPlan>($"/v2/billing/pricing_plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Pricing Plan object.
        /// </summary>
        public virtual PricingPlan Update(string id, PricingPlanUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PricingPlan>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Pricing Plan object.
        /// </summary>
        public virtual Task<PricingPlan> UpdateAsync(string id, PricingPlanUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PricingPlan>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

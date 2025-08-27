// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using System;
    using System.Collections.Generic;
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
        /// Create a Pricing Plan Component object.
        /// </summary>
        public virtual V2.Billing.PricingPlanComponent Create(string id, ComponentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/components", options, requestOptions);
        }

        /// <summary>
        /// Create a Pricing Plan Component object.
        /// </summary>
        public virtual Task<V2.Billing.PricingPlanComponent> CreateAsync(string id, ComponentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/components", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Remove a Pricing Plan Component from the latest version of a Pricing Plan.
        /// </summary>
        public virtual V2.Billing.PricingPlanComponent Delete(string parentId, string id, ComponentDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/components/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Remove a Pricing Plan Component from the latest version of a Pricing Plan.
        /// </summary>
        public virtual Task<V2.Billing.PricingPlanComponent> DeleteAsync(string parentId, string id, ComponentDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/components/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Pricing Plan Component object.
        /// </summary>
        public virtual V2.Billing.PricingPlanComponent Get(string parentId, string id, ComponentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/components/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Pricing Plan Component object.
        /// </summary>
        public virtual Task<V2.Billing.PricingPlanComponent> GetAsync(string parentId, string id, ComponentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/components/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Pricing Plan Component objects for a Pricing Plan.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.PricingPlanComponent> List(string id, ComponentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.PricingPlanComponent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/components", options, requestOptions);
        }

        /// <summary>
        /// List all Pricing Plan Component objects for a Pricing Plan.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.PricingPlanComponent>> ListAsync(string id, ComponentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.PricingPlanComponent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/components", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Pricing Plan Component objects for a Pricing Plan.
        /// </summary>
        public virtual IEnumerable<V2.Billing.PricingPlanComponent> ListAutoPaging(string id, ComponentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.PricingPlanComponent>($"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/components", options, requestOptions);
        }

        /// <summary>
        /// List all Pricing Plan Component objects for a Pricing Plan.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.PricingPlanComponent> ListAutoPagingAsync(string id, ComponentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.PricingPlanComponent>($"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/components", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Pricing Plan Component object.
        /// </summary>
        public virtual V2.Billing.PricingPlanComponent Update(string parentId, string id, ComponentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/components/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Pricing Plan Component object.
        /// </summary>
        public virtual Task<V2.Billing.PricingPlanComponent> UpdateAsync(string parentId, string id, ComponentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.PricingPlanComponent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/components/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

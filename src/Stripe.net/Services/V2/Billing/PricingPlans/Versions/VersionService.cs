// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VersionService : Service
    {
        internal VersionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal VersionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a specific version of a PricingPlan.
        /// </summary>
        public virtual V2.Billing.PricingPlanVersion Get(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.PricingPlanVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a specific version of a PricingPlan.
        /// </summary>
        public virtual Task<V2.Billing.PricingPlanVersion> GetAsync(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.PricingPlanVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all versions of a PricingPlan.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.PricingPlanVersion> List(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.PricingPlanVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all versions of a PricingPlan.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.PricingPlanVersion>> ListAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.PricingPlanVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all versions of a PricingPlan.
        /// </summary>
        public virtual IEnumerable<V2.Billing.PricingPlanVersion> ListAutoPaging(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.PricingPlanVersion>($"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all versions of a PricingPlan.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.PricingPlanVersion> ListAutoPagingAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.PricingPlanVersion>($"/v2/billing/pricing_plans/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }
    }
}

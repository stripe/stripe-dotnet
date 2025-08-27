// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomPricingUnitService : Service
    {
        internal CustomPricingUnitService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CustomPricingUnitService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a Custom Pricing Unit object.
        /// </summary>
        public virtual CustomPricingUnit Create(CustomPricingUnitCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomPricingUnit>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/custom_pricing_units", options, requestOptions);
        }

        /// <summary>
        /// Create a Custom Pricing Unit object.
        /// </summary>
        public virtual Task<CustomPricingUnit> CreateAsync(CustomPricingUnitCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomPricingUnit>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/custom_pricing_units", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Custom Pricing Unit object.
        /// </summary>
        public virtual CustomPricingUnit Get(string id, CustomPricingUnitGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomPricingUnit>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/custom_pricing_units/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Custom Pricing Unit object.
        /// </summary>
        public virtual Task<CustomPricingUnit> GetAsync(string id, CustomPricingUnitGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomPricingUnit>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/custom_pricing_units/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Custom Pricing Unit objects.
        /// </summary>
        public virtual V2.StripeList<CustomPricingUnit> List(CustomPricingUnitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<CustomPricingUnit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/custom_pricing_units", options, requestOptions);
        }

        /// <summary>
        /// List all Custom Pricing Unit objects.
        /// </summary>
        public virtual Task<V2.StripeList<CustomPricingUnit>> ListAsync(CustomPricingUnitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<CustomPricingUnit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/custom_pricing_units", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Custom Pricing Unit objects.
        /// </summary>
        public virtual IEnumerable<CustomPricingUnit> ListAutoPaging(CustomPricingUnitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomPricingUnit>($"/v2/billing/custom_pricing_units", options, requestOptions);
        }

        /// <summary>
        /// List all Custom Pricing Unit objects.
        /// </summary>
        public virtual IAsyncEnumerable<CustomPricingUnit> ListAutoPagingAsync(CustomPricingUnitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomPricingUnit>($"/v2/billing/custom_pricing_units", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Custom Pricing Unit object.
        /// </summary>
        public virtual CustomPricingUnit Update(string id, CustomPricingUnitUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomPricingUnit>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/custom_pricing_units/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Custom Pricing Unit object.
        /// </summary>
        public virtual Task<CustomPricingUnit> UpdateAsync(string id, CustomPricingUnitUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomPricingUnit>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/custom_pricing_units/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

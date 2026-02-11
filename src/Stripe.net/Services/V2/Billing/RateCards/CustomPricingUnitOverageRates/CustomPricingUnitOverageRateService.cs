// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomPricingUnitOverageRateService : Service
    {
        internal CustomPricingUnitOverageRateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CustomPricingUnitOverageRateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a Rate Card Custom Pricing Unit Overage Rate on a Rate Card.
        /// </summary>
        public virtual V2.Billing.RateCardCustomPricingUnitOverageRate Create(string id, CustomPricingUnitOverageRateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.RateCardCustomPricingUnitOverageRate>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/custom_pricing_unit_overage_rates", options, requestOptions);
        }

        /// <summary>
        /// Create a Rate Card Custom Pricing Unit Overage Rate on a Rate Card.
        /// </summary>
        public virtual Task<V2.Billing.RateCardCustomPricingUnitOverageRate> CreateAsync(string id, CustomPricingUnitOverageRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.RateCardCustomPricingUnitOverageRate>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/custom_pricing_unit_overage_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Delete a Rate Card Custom Pricing Unit Overage Rate from a Rate Card.
        /// </summary>
        public virtual V2.DeletedObject Delete(string parentId, string id, CustomPricingUnitOverageRateDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/custom_pricing_unit_overage_rates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Delete a Rate Card Custom Pricing Unit Overage Rate from a Rate Card.
        /// </summary>
        public virtual Task<V2.DeletedObject> DeleteAsync(string parentId, string id, CustomPricingUnitOverageRateDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/custom_pricing_unit_overage_rates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Rate Card Custom Pricing Unit Overage Rate from a Rate Card.
        /// </summary>
        public virtual V2.Billing.RateCardCustomPricingUnitOverageRate Get(string parentId, string id, CustomPricingUnitOverageRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.RateCardCustomPricingUnitOverageRate>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/custom_pricing_unit_overage_rates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Rate Card Custom Pricing Unit Overage Rate from a Rate Card.
        /// </summary>
        public virtual Task<V2.Billing.RateCardCustomPricingUnitOverageRate> GetAsync(string parentId, string id, CustomPricingUnitOverageRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.RateCardCustomPricingUnitOverageRate>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/custom_pricing_unit_overage_rates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rate Card Custom Pricing Unit Overage Rates on a Rate Card.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.RateCardCustomPricingUnitOverageRate> List(string id, CustomPricingUnitOverageRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.RateCardCustomPricingUnitOverageRate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/custom_pricing_unit_overage_rates", options, requestOptions);
        }

        /// <summary>
        /// List all Rate Card Custom Pricing Unit Overage Rates on a Rate Card.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.RateCardCustomPricingUnitOverageRate>> ListAsync(string id, CustomPricingUnitOverageRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.RateCardCustomPricingUnitOverageRate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/custom_pricing_unit_overage_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rate Card Custom Pricing Unit Overage Rates on a Rate Card.
        /// </summary>
        public virtual IEnumerable<V2.Billing.RateCardCustomPricingUnitOverageRate> ListAutoPaging(string id, CustomPricingUnitOverageRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.RateCardCustomPricingUnitOverageRate>($"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/custom_pricing_unit_overage_rates", options, requestOptions);
        }

        /// <summary>
        /// List all Rate Card Custom Pricing Unit Overage Rates on a Rate Card.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.RateCardCustomPricingUnitOverageRate> ListAutoPagingAsync(string id, CustomPricingUnitOverageRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.RateCardCustomPricingUnitOverageRate>($"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/custom_pricing_unit_overage_rates", options, requestOptions, cancellationToken);
        }
    }
}

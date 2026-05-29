// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Contracts.LicensePricing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuantityChangeService : Service
    {
        internal QuantityChangeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal QuantityChangeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// List license quantity changes for a contract given a license pricing ID.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.ContractLicensePricingQuantityChange> ListQuantityChanges(string parentId, string id, QuantityChangeListQuantityChangesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.ContractLicensePricingQuantityChange>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/license_pricing/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions);
        }

        /// <summary>
        /// List license quantity changes for a contract given a license pricing ID.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.ContractLicensePricingQuantityChange>> ListQuantityChangesAsync(string parentId, string id, QuantityChangeListQuantityChangesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.ContractLicensePricingQuantityChange>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/license_pricing/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List license quantity changes for a contract given a license pricing ID.
        /// </summary>
        public virtual IEnumerable<V2.Billing.ContractLicensePricingQuantityChange> ListQuantityChangesAutoPaging(string parentId, string id, QuantityChangeListQuantityChangesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.ContractLicensePricingQuantityChange>($"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/license_pricing/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions);
        }

        /// <summary>
        /// List license quantity changes for a contract given a license pricing ID.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.ContractLicensePricingQuantityChange> ListQuantityChangesAutoPagingAsync(string parentId, string id, QuantityChangeListQuantityChangesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.ContractLicensePricingQuantityChange>($"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/license_pricing/{WebUtility.UrlEncode(id)}/quantity_changes", options, requestOptions, cancellationToken);
        }
    }
}

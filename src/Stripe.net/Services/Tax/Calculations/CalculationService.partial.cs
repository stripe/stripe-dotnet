namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class CalculationService
    {
        /// <summary>
        /// <p>Retrieves the line items of a persisted tax calculation as a collection.</p>.
        /// </summary>
        [Obsolete("Use CalculationLineItemService.List instead.")]
        public virtual StripeList<CalculationLineItem> ListLineItems(string id, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CalculationLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a persisted tax calculation as a collection.</p>.
        /// </summary>
        [Obsolete("Use CalculationLineItemService.ListAsync instead.")]
        public virtual Task<StripeList<CalculationLineItem>> ListLineItemsAsync(string id, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CalculationLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the line items of a persisted tax calculation as a collection.</p>.
        /// </summary>
        [Obsolete("Use CalculationLineItemService.ListAutoPaging instead.")]
        public virtual IEnumerable<CalculationLineItem> ListLineItemsAutoPaging(string id, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CalculationLineItem>($"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a persisted tax calculation as a collection.</p>.
        /// </summary>
        [Obsolete("Use CalculationLineItemService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<CalculationLineItem> ListLineItemsAutoPagingAsync(string id, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CalculationLineItem>($"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }
    }
}

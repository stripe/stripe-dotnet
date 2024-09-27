// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CalculationLineItemService : ServiceNested<CalculationLineItem>,
        INestedListable<CalculationLineItem, CalculationLineItemListOptions>
    {
        public CalculationLineItemService()
        {
        }

        internal CalculationLineItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CalculationLineItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual StripeList<CalculationLineItem> List(string parentId, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CalculationLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual Task<StripeList<CalculationLineItem>> ListAsync(string parentId, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CalculationLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual IEnumerable<CalculationLineItem> ListAutoPaging(string parentId, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CalculationLineItem>($"/v1/tax/calculations/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CalculationLineItem> ListAutoPagingAsync(string parentId, CalculationLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CalculationLineItem>($"/v1/tax/calculations/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions, cancellationToken);
        }
    }
}

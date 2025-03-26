// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionLineItemService : ServiceNested<TransactionLineItem>,
        INestedListable<TransactionLineItem, TransactionLineItemListOptions>
    {
        public TransactionLineItemService()
        {
        }

        internal TransactionLineItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TransactionLineItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        public virtual StripeList<TransactionLineItem> List(string parentId, TransactionLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TransactionLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/transactions/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        public virtual Task<StripeList<TransactionLineItem>> ListAsync(string parentId, TransactionLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TransactionLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/transactions/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        public virtual IEnumerable<TransactionLineItem> ListAutoPaging(string parentId, TransactionLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransactionLineItem>($"/v1/tax/transactions/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TransactionLineItem> ListAutoPagingAsync(string parentId, TransactionLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransactionLineItem>($"/v1/tax/transactions/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions, cancellationToken);
        }
    }
}

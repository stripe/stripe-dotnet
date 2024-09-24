namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class TransactionService
    {
        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        [Obsolete("Use TransactionLineItemService.List instead.")]
        public virtual StripeList<TransactionLineItem> ListLineItems(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TransactionLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/transactions/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        [Obsolete("Use TransactionLineItemService.ListAsync instead.")]
        public virtual Task<StripeList<TransactionLineItem>> ListLineItemsAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TransactionLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/transactions/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        [Obsolete("Use TransactionLineItemService.ListAutoPaging instead.")]
        public virtual IEnumerable<TransactionLineItem> ListLineItemsAutoPaging(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransactionLineItem>($"/v1/tax/transactions/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a committed standalone transaction as a collection.</p>.
        /// </summary>
        [Obsolete("Use TransactionLineItemService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<TransactionLineItem> ListLineItemsAutoPagingAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransactionLineItem>($"/v1/tax/transactions/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}

namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class CreditNoteService : Service<CreditNote>,
        ICreatable<CreditNote, CreditNoteCreateOptions>,
        IListable<CreditNote, CreditNoteListOptions>,
        IRetrievable<CreditNote, CreditNoteGetOptions>,
        IUpdatable<CreditNote, CreditNoteUpdateOptions>
    {
        [Obsolete("Use CreditNotePreviewLinesService.List instead.")]
        public virtual StripeList<CreditNoteLineItem> ListPreviewLineItems(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNoteLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/preview/lines", options, requestOptions);
        }

        [Obsolete("Use CreditNotePreviewLinesService.ListAsync instead.")]
        public virtual Task<StripeList<CreditNoteLineItem>> ListPreviewLineItemsAsync(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNoteLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/preview/lines", options, requestOptions, cancellationToken);
        }

        [Obsolete("Use CreditNotePreviewLinesService.ListAutoPaging instead.")]
        public virtual IEnumerable<CreditNoteLineItem> ListPreviewLineItemsAutoPaging(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNoteLineItem>($"/v1/credit_notes/preview/lines", options, requestOptions);
        }

        [Obsolete("Use CreditNotePreviewLinesService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<CreditNoteLineItem> ListPreviewLineItemsAutoPagingAsync(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditNoteLineItem>($"/v1/credit_notes/preview/lines", options, requestOptions, cancellationToken);
        }
    }
}

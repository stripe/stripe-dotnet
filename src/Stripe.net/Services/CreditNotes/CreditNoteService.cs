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
        private CreditNotePreviewLinesService previewLines;

        public CreditNoteService()
            : base()
        {
        }

        internal CreditNoteService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CreditNoteService(IStripeClient client)
            : base(client)
        {
        }

        public virtual CreditNotePreviewLinesService PreviewLines => this.previewLines ??= new CreditNotePreviewLinesService(
            this.Requestor);

        public virtual CreditNote Create(CreditNoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(BaseAddress.Api, HttpMethod.Post, $"/v1/credit_notes", options, requestOptions);
        }

        public virtual Task<CreditNote> CreateAsync(CreditNoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(BaseAddress.Api, HttpMethod.Post, $"/v1/credit_notes", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Get(string id, CreditNoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/{id}", options, requestOptions);
        }

        public virtual Task<CreditNote> GetAsync(string id, CreditNoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditNote> List(CreditNoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNote>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes", options, requestOptions);
        }

        public virtual Task<StripeList<CreditNote>> ListAsync(CreditNoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNote>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNote> ListAutoPaging(CreditNoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNote>($"/v1/credit_notes", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditNote> ListAutoPagingAsync(CreditNoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditNote>($"/v1/credit_notes", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditNoteLineItem> ListLineItems(string id, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNoteLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/{id}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<CreditNoteLineItem>> ListLineItemsAsync(string id, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNoteLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNoteLineItem> ListLineItemsAutoPaging(string id, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNoteLineItem>($"/v1/credit_notes/{id}/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditNoteLineItem> ListLineItemsAutoPagingAsync(string id, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditNoteLineItem>($"/v1/credit_notes/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Preview(CreditNotePreviewOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/preview", options, requestOptions);
        }

        public virtual Task<CreditNote> PreviewAsync(CreditNotePreviewOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/preview", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Update(string id, CreditNoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(BaseAddress.Api, HttpMethod.Post, $"/v1/credit_notes/{id}", options, requestOptions);
        }

        public virtual Task<CreditNote> UpdateAsync(string id, CreditNoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(BaseAddress.Api, HttpMethod.Post, $"/v1/credit_notes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote VoidCreditNote(string id, CreditNoteVoidOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(BaseAddress.Api, HttpMethod.Post, $"/v1/credit_notes/{id}/void", options, requestOptions);
        }

        public virtual Task<CreditNote> VoidCreditNoteAsync(string id, CreditNoteVoidOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(BaseAddress.Api, HttpMethod.Post, $"/v1/credit_notes/{id}/void", options, requestOptions, cancellationToken);
        }
    }
}

namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditNoteService : Service<CreditNote>,
        ICreatable<CreditNote, CreditNoteCreateOptions>,
        IListable<CreditNote, CreditNoteListOptions>,
        IRetrievable<CreditNote, CreditNoteGetOptions>,
        IUpdatable<CreditNote, CreditNoteUpdateOptions>
    {
        public CreditNoteService()
            : base(null)
        {
        }

        public CreditNoteService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/credit_notes";

        public virtual CreditNote Create(CreditNoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(HttpMethod.Post, $"/v1/credit_notes", options, requestOptions);
        }

        public virtual Task<CreditNote> CreateAsync(CreditNoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(HttpMethod.Post, $"/v1/credit_notes", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Get(string id, CreditNoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(HttpMethod.Get, $"/v1/credit_notes/{id}", options, requestOptions);
        }

        public virtual Task<CreditNote> GetAsync(string id, CreditNoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(HttpMethod.Get, $"/v1/credit_notes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditNote> List(CreditNoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNote>>(HttpMethod.Get, $"/v1/credit_notes", options, requestOptions);
        }

        public virtual Task<StripeList<CreditNote>> ListAsync(CreditNoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNote>>(HttpMethod.Get, $"/v1/credit_notes", options, requestOptions, cancellationToken);
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
            return this.Request<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"/v1/credit_notes/{id}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<CreditNoteLineItem>> ListLineItemsAsync(string id, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"/v1/credit_notes/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNoteLineItem> ListLineItemsAutoPaging(string id, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNoteLineItem>($"/v1/credit_notes/{id}/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditNoteLineItem> ListLineItemsAutoPagingAsync(string id, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditNoteLineItem>($"/v1/credit_notes/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditNoteLineItem> ListPreviewLineItems(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"/v1/credit_notes/preview/lines", options, requestOptions);
        }

        public virtual Task<StripeList<CreditNoteLineItem>> ListPreviewLineItemsAsync(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"/v1/credit_notes/preview/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNoteLineItem> ListPreviewLineItemsAutoPaging(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNoteLineItem>($"/v1/credit_notes/preview/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditNoteLineItem> ListPreviewLineItemsAutoPagingAsync(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditNoteLineItem>($"/v1/credit_notes/preview/lines", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Preview(CreditNotePreviewOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"/v1/credit_notes/preview", options, requestOptions);
        }

        public virtual Task<CreditNote> PreviewAsync(CreditNotePreviewOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, $"/v1/credit_notes/preview", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Update(string id, CreditNoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNote>(HttpMethod.Post, $"/v1/credit_notes/{id}", options, requestOptions);
        }

        public virtual Task<CreditNote> UpdateAsync(string id, CreditNoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNote>(HttpMethod.Post, $"/v1/credit_notes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote VoidCreditNote(string id, CreditNoteVoidOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"/v1/credit_notes/{id}/void", options, requestOptions);
        }

        public virtual Task<CreditNote> VoidCreditNoteAsync(string id, CreditNoteVoidOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"/v1/credit_notes/{id}/void", options, requestOptions, cancellationToken);
        }
    }
}

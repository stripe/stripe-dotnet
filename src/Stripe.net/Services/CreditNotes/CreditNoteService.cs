namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

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

        public override string BasePath => "/v1/credit_notes";

        public virtual CreditNote Create(CreditNoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<CreditNote> CreateAsync(CreditNoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Get(string id, CreditNoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<CreditNote> GetAsync(string id, CreditNoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditNote> List(CreditNoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CreditNote>> ListAsync(CreditNoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNote> ListAutoPaging(CreditNoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual CreditNote Preview(string id, CreditNotePreviewOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"{this.InstanceUrl("preview")}", options, requestOptions);
        }

        public virtual Task<CreditNote> PreviewAsync(string id, CreditNotePreviewOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, $"{this.InstanceUrl("preview")}", options, requestOptions, cancellationToken);
        }

        public virtual CreditNoteLinesList PreviewLines(string id, CreditNotePreviewLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditNoteLinesList>(HttpMethod.Get, $"{this.InstanceUrl("preview")}/lines, options, requestOptions);
        }

        public virtual Task<CreditNoteLinesList> PreviewLinesAsync(string id, CreditNotePreviewLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditNoteLinesList>(HttpMethod.Get, $"{this.InstanceUrl("preview")}/lines, options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Update(string id, CreditNoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<CreditNote> UpdateAsync(string id, CreditNoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual CreditNote VoidCreditNote(string id, CreditNoteVoidCreditNoteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/void", options, requestOptions);
        }

        public virtual Task<CreditNote> VoidCreditNoteAsync(string id, CreditNoteVoidCreditNoteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/void", options, requestOptions, cancellationToken);
        }
    }
}

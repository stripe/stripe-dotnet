namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class InvoiceService : Service<Invoice>,
        ICreatable<Invoice, InvoiceCreateOptions>,
        IListable<Invoice, InvoiceListOptions>,
        IRetrievable<Invoice, InvoiceGetOptions>,
        IUpdatable<Invoice, InvoiceUpdateOptions>
    {
        public InvoiceService()
            : base(null)
        {
        }

        public InvoiceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/invoices";

        public virtual Invoice Create(InvoiceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Invoice> CreateAsync(InvoiceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Invoice Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

        public virtual Task<Invoice> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual Invoice FinalizeInvoice(string id, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/finalize", options, requestOptions);
        }

        public virtual Task<Invoice> FinalizeInvoiceAsync(string id, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/finalize", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Get(string id, InvoiceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Invoice> GetAsync(string id, InvoiceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Invoice> List(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Invoice>> ListAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Invoice> ListAutoPaging(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual StripeList<InvoiceLineItem> ListLineItems(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListLineItemsAutoPaging(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl(id)}/lines", options, requestOptions);
        }

        public virtual StripeList<InvoiceLineItem> ListUpcomingLineItems(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListUpcomingLineItemsAsync(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListUpcomingLineItemsAutoPaging(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl("upcoming")}/lines", options, requestOptions);
        }

        public virtual Invoice MarkUncollectible(string id, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_uncollectible", options, requestOptions);
        }

        public virtual Task<Invoice> MarkUncollectibleAsync(string id, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_uncollectible", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Pay(string id, InvoicePayOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/pay", options, requestOptions);
        }

        public virtual Task<Invoice> PayAsync(string id, InvoicePayOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/pay", options, requestOptions, cancellationToken);
        }

        public virtual Invoice SendInvoice(string id, InvoiceSendOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/send", options, requestOptions);
        }

        public virtual Task<Invoice> SendInvoiceAsync(string id, InvoiceSendOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/send", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Upcoming(UpcomingInvoiceOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}", options, requestOptions);
        }

        public virtual Task<Invoice> UpcomingAsync(UpcomingInvoiceOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Update(string id, InvoiceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Invoice> UpdateAsync(string id, InvoiceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Invoice VoidInvoice(string id, InvoiceVoidOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/void", options, requestOptions);
        }

        public virtual Task<Invoice> VoidInvoiceAsync(string id, InvoiceVoidOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/void", options, requestOptions, cancellationToken);
        }
    }
}

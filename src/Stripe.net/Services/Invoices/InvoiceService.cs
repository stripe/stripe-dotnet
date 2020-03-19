namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceService : Service<Invoice>,
        ICreatable<Invoice, InvoiceCreateOptions>,
        IDeletable<Invoice, InvoiceDeleteOptions>,
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

        public virtual Task<Invoice> CreateAsync(InvoiceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Invoice Delete(string invoiceId, InvoiceDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(invoiceId, options, requestOptions);
        }

        public virtual Task<Invoice> DeleteAsync(string invoiceId, InvoiceDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(invoiceId, options, requestOptions, cancellationToken);
        }

        public virtual Invoice FinalizeInvoice(string invoiceId, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/finalize", options, requestOptions);
        }

        public virtual Task<Invoice> FinalizeInvoiceAsync(string invoiceId, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/finalize", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Get(string invoiceId, InvoiceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(invoiceId, options, requestOptions);
        }

        public virtual Task<Invoice> GetAsync(string invoiceId, InvoiceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(invoiceId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Invoice> List(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Invoice>> ListAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Invoice> ListAutoPaging(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Invoice> ListAutoPagingAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual StripeList<InvoiceLineItem> ListLineItems(string invoiceId, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(invoiceId)}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string invoiceId, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(invoiceId)}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListLineItemsAutoPaging(string invoiceId, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl(invoiceId)}/lines", options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<InvoiceLineItem> ListLineItemsAutoPagingAsync(string invoiceId, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"{this.InstanceUrl(invoiceId)}/lines", options, requestOptions, cancellationToken);
        }
#endif

        public virtual StripeList<InvoiceLineItem> ListUpcomingLineItems(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListUpcomingLineItemsAsync(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListUpcomingLineItemsAutoPaging(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl("upcoming")}/lines", options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<InvoiceLineItem> ListUpcomingLineItemsAutoPagingAsync(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"{this.InstanceUrl("upcoming")}/lines", options, requestOptions, cancellationToken);
        }
#endif

        public virtual Invoice MarkUncollectible(string invoiceId, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/mark_uncollectible", options, requestOptions);
        }

        public virtual Task<Invoice> MarkUncollectibleAsync(string invoiceId, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/mark_uncollectible", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Pay(string invoiceId, InvoicePayOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/pay", options, requestOptions);
        }

        public virtual Task<Invoice> PayAsync(string invoiceId, InvoicePayOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/pay", options, requestOptions, cancellationToken);
        }

        public virtual Invoice SendInvoice(string invoiceId, InvoiceSendOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/send", options, requestOptions);
        }

        public virtual Task<Invoice> SendInvoiceAsync(string invoiceId, InvoiceSendOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/send", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Upcoming(UpcomingInvoiceOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}", options, requestOptions);
        }

        public virtual Task<Invoice> UpcomingAsync(UpcomingInvoiceOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Update(string invoiceId, InvoiceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(invoiceId, options, requestOptions);
        }

        public virtual Task<Invoice> UpdateAsync(string invoiceId, InvoiceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(invoiceId, options, requestOptions, cancellationToken);
        }

        public virtual Invoice VoidInvoice(string invoiceId, InvoiceVoidOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/void", options, requestOptions);
        }

        public virtual Task<Invoice> VoidInvoiceAsync(string invoiceId, InvoiceVoidOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/void", options, requestOptions, cancellationToken);
        }
    }
}

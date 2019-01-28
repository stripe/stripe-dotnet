namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceService : Service<Invoice>,
        ICreatable<Invoice, InvoiceCreateOptions>,
        IListable<Invoice, InvoiceListOptions>,
        IRetrievable<Invoice>,
        IUpdatable<Invoice, InvoiceUpdateOptions>
    {
        public InvoiceService()
            : base(null)
        {
        }

        public InvoiceService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/invoices";

        public bool ExpandCharge { get; set; }

        public bool ExpandCustomer { get; set; }

        public bool ExpandDefaultPaymentMethod { get; set; }

        public bool ExpandSubscription { get; set; }

        public virtual Invoice Create(InvoiceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Invoice> CreateAsync(InvoiceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Invoice Delete(string invoiceId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(invoiceId, null, requestOptions);
        }

        public virtual Task<Invoice> DeleteAsync(string invoiceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(invoiceId, null, requestOptions, cancellationToken);
        }

        public virtual Invoice FinalizeInvoice(string invoiceId, InvoiceFinalizeOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/finalize", options, requestOptions);
        }

        public virtual Task<Invoice> FinalizeInvoiceAsync(string invoiceId, InvoiceFinalizeOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/finalize", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Get(string invoiceId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(invoiceId, null, requestOptions);
        }

        public virtual Task<Invoice> GetAsync(string invoiceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(invoiceId, null, requestOptions, cancellationToken);
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

        public virtual StripeList<InvoiceLineItem> ListLineItems(string invoiceId, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(invoiceId)}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string invoiceId, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(invoiceId)}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListLineItemsAutoPaging(string invoiceId, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl(invoiceId)}/lines", options, requestOptions);
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

        public virtual Invoice MarkUncollectible(string invoiceId, InvoiceMarkUncollectibleOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/mark_uncollectible", options, requestOptions);
        }

        public virtual Task<Invoice> MarkUncollectibleAsync(string invoiceId, InvoiceMarkUncollectibleOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/mark_uncollectible", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Pay(string invoiceId, InvoicePayOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/pay", options, requestOptions);
        }

        public virtual Task<Invoice> PayAsync(string invoiceId, InvoicePayOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/pay", options, requestOptions, cancellationToken);
        }

        public virtual Invoice SendInvoice(string invoiceId, InvoiceSendOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/send", options, requestOptions);
        }

        public virtual Task<Invoice> SendInvoiceAsync(string invoiceId, InvoiceSendOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/send", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Upcoming(UpcomingInvoiceOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}", options, requestOptions);
        }

        public virtual Task<Invoice> UpcomingAsync(UpcomingInvoiceOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Get, $"{this.InstanceUrl("upcoming")}", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Update(string invoiceId, InvoiceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(invoiceId, options, requestOptions);
        }

        public virtual Task<Invoice> UpdateAsync(string invoiceId, InvoiceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(invoiceId, options, requestOptions, cancellationToken);
        }

        public virtual Invoice VoidInvoice(string invoiceId, InvoiceVoidOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/void", options, requestOptions);
        }

        public virtual Task<Invoice> VoidInvoiceAsync(string invoiceId, InvoiceVoidOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(invoiceId)}/void", options, requestOptions, cancellationToken);
        }
    }
}

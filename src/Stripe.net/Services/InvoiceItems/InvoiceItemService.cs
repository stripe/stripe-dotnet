namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceItemService : Service<InvoiceItem>,
        ICreatable<InvoiceItem, InvoiceItemCreateOptions>,
        IDeletable<InvoiceItem>,
        IListable<InvoiceItem, InvoiceItemListOptions>,
        IRetrievable<InvoiceItem>,
        IUpdatable<InvoiceItem, InvoiceItemUpdateOptions>
    {
        public InvoiceItemService()
            : base(null)
        {
        }

        public InvoiceItemService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/invoiceitems";

        public bool ExpandCustomer { get; set; }

        public bool ExpandInvoice { get; set; }

        public bool ExpandSubscription { get; set; }

        public virtual InvoiceItem Create(InvoiceItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<InvoiceItem> CreateAsync(InvoiceItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Delete(string invoiceitemId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(invoiceitemId, null, requestOptions);
        }

        public virtual Task<InvoiceItem> DeleteAsync(string invoiceitemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(invoiceitemId, null, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Get(string invoiceitemId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(invoiceitemId, null, requestOptions);
        }

        public virtual Task<InvoiceItem> GetAsync(string invoiceitemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(invoiceitemId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceItem> List(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceItem>> ListAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceItem> ListAutoPaging(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual InvoiceItem Update(string invoiceitemId, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(invoiceitemId, options, requestOptions);
        }

        public virtual Task<InvoiceItem> UpdateAsync(string invoiceitemId, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(invoiceitemId, options, requestOptions, cancellationToken);
        }
    }
}

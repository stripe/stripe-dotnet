namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class InvoiceItemService : Service<InvoiceLineItem>,
        ICreatable<InvoiceLineItem, InvoiceItemCreateOptions>,
        IDeletable<InvoiceLineItem>,
        IListable<InvoiceLineItem, InvoiceItemListOptions>,
        IRetrievable<InvoiceLineItem>,
        IUpdatable<InvoiceLineItem, InvoiceItemUpdateOptions>
    {
        public InvoiceItemService()
            : base(null)
        {
        }

        public InvoiceItemService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public bool ExpandInvoice { get; set; }

        public bool ExpandSubscription { get; set; }

        public virtual InvoiceLineItem Create(InvoiceItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/invoiceitems", requestOptions, options);
        }

        public virtual Task<InvoiceLineItem> CreateAsync(InvoiceItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/invoiceitems", requestOptions, cancellationToken, options);
        }

        public virtual InvoiceLineItem Delete(string invoiceitemId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/invoiceitems/{invoiceitemId}", requestOptions);
        }

        public virtual Task<InvoiceLineItem> DeleteAsync(string invoiceitemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/invoiceitems/{invoiceitemId}", requestOptions, cancellationToken);
        }

        public virtual InvoiceLineItem Get(string invoiceitemId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/invoiceitems/{invoiceitemId}", requestOptions);
        }

        public virtual Task<InvoiceLineItem> GetAsync(string invoiceitemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/invoiceitems/{invoiceitemId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceLineItem> List(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/invoiceitems", requestOptions, options);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/invoiceitems", requestOptions, cancellationToken, options);
        }

        public virtual InvoiceLineItem Update(string invoiceitemId, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/invoiceitems/{invoiceitemId}", requestOptions, options);
        }

        public virtual Task<InvoiceLineItem> UpdateAsync(string invoiceitemId, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/invoiceitems/{invoiceitemId}", requestOptions, cancellationToken, options);
        }
    }
}

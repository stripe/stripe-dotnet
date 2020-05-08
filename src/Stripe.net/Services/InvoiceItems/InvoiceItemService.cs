namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class InvoiceItemService : Service<InvoiceItem>,
        ICreatable<InvoiceItem, InvoiceItemCreateOptions>,
        IDeletable<InvoiceItem, InvoiceItemDeleteOptions>,
        IListable<InvoiceItem, InvoiceItemListOptions>,
        IRetrievable<InvoiceItem, InvoiceItemGetOptions>,
        IUpdatable<InvoiceItem, InvoiceItemUpdateOptions>
    {
        public InvoiceItemService()
            : base(null)
        {
        }

        public InvoiceItemService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/invoiceitems";

        public virtual InvoiceItem Create(InvoiceItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<InvoiceItem> CreateAsync(InvoiceItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

        public virtual Task<InvoiceItem> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Get(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<InvoiceItem> GetAsync(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceItem> List(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceItem>> ListAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceItem> ListAutoPaging(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual InvoiceItem Update(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<InvoiceItem> UpdateAsync(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

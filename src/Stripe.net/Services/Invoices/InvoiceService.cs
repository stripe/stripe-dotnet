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
#pragma warning disable CS0618 // Type or member is obsolete
        public InvoiceService()
            : base(null)
        {
        }

        public InvoiceService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/invoices";

        public virtual Invoice Create(InvoiceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(HttpMethod.Post, $"/v1/invoices", options, requestOptions);
        }

        public virtual Task<Invoice> CreateAsync(InvoiceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(HttpMethod.Post, $"/v1/invoices", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Delete(string id, InvoiceDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(HttpMethod.Delete, $"/v1/invoices/{id}", options, requestOptions);
        }

        public virtual Task<Invoice> DeleteAsync(string id, InvoiceDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(HttpMethod.Delete, $"/v1/invoices/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Invoice FinalizeInvoice(string id, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"/v1/invoices/{id}/finalize", options, requestOptions);
        }

        public virtual Task<Invoice> FinalizeInvoiceAsync(string id, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"/v1/invoices/{id}/finalize", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Get(string id, InvoiceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(HttpMethod.Get, $"/v1/invoices/{id}", options, requestOptions);
        }

        public virtual Task<Invoice> GetAsync(string id, InvoiceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(HttpMethod.Get, $"/v1/invoices/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Invoice> List(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Invoice>>(HttpMethod.Get, $"/v1/invoices", options, requestOptions);
        }

        public virtual Task<StripeList<Invoice>> ListAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Invoice>>(HttpMethod.Get, $"/v1/invoices", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Invoice> ListAutoPaging(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Invoice>($"/v1/invoices", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Invoice> ListAutoPagingAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Invoice>($"/v1/invoices", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceLineItem> ListLineItems(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"/v1/invoices/{id}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"/v1/invoices/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListLineItemsAutoPaging(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/{id}/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoiceLineItem> ListLineItemsAutoPagingAsync(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceLineItem> ListUpcomingLineItems(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"/v1/invoices/upcoming/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListUpcomingLineItemsAsync(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"/v1/invoices/upcoming/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListUpcomingLineItemsAutoPaging(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/upcoming/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoiceLineItem> ListUpcomingLineItemsAutoPagingAsync(UpcomingInvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/upcoming/lines", options, requestOptions, cancellationToken);
        }

        public virtual Invoice MarkUncollectible(string id, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"/v1/invoices/{id}/mark_uncollectible", options, requestOptions);
        }

        public virtual Task<Invoice> MarkUncollectibleAsync(string id, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"/v1/invoices/{id}/mark_uncollectible", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Pay(string id, InvoicePayOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"/v1/invoices/{id}/pay", options, requestOptions);
        }

        public virtual Task<Invoice> PayAsync(string id, InvoicePayOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"/v1/invoices/{id}/pay", options, requestOptions, cancellationToken);
        }

        public virtual StripeSearchResult<Invoice> Search(InvoiceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Invoice>>(HttpMethod.Get, $"/v1/invoices/search", options, requestOptions);
        }

        public virtual Task<StripeSearchResult<Invoice>> SearchAsync(InvoiceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Invoice>>(HttpMethod.Get, $"/v1/invoices/search", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Invoice> SearchAutoPaging(InvoiceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Invoice>($"/v1/invoices/search", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Invoice> SearchAutoPagingAsync(InvoiceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Invoice>($"/v1/invoices/search", options, requestOptions, cancellationToken);
        }

        public virtual Invoice SendInvoice(string id, InvoiceSendOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"/v1/invoices/{id}/send", options, requestOptions);
        }

        public virtual Task<Invoice> SendInvoiceAsync(string id, InvoiceSendOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"/v1/invoices/{id}/send", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Upcoming(UpcomingInvoiceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"/v1/invoices/upcoming", options, requestOptions);
        }

        public virtual Task<Invoice> UpcomingAsync(UpcomingInvoiceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, $"/v1/invoices/upcoming", options, requestOptions, cancellationToken);
        }

        public virtual Invoice Update(string id, InvoiceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(HttpMethod.Post, $"/v1/invoices/{id}", options, requestOptions);
        }

        public virtual Task<Invoice> UpdateAsync(string id, InvoiceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(HttpMethod.Post, $"/v1/invoices/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Invoice VoidInvoice(string id, InvoiceVoidOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"/v1/invoices/{id}/void", options, requestOptions);
        }

        public virtual Task<Invoice> VoidInvoiceAsync(string id, InvoiceVoidOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"/v1/invoices/{id}/void", options, requestOptions, cancellationToken);
        }
#pragma warning restore CS0618 // Type or member is obsolete
    }
}

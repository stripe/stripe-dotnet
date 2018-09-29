namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class InvoiceService : Service<Invoice>,
        ICreatable<Invoice, InvoiceCreateOptions>,
        IListable<Invoice, InvoiceListOptions>,
        IRetrievable<Invoice>,
        IUpdatable<Invoice, InvoiceUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/invoices";

        public InvoiceService()
            : base(null)
        {
        }

        public InvoiceService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCharge { get; set; }

        public bool ExpandCustomer { get; set; }

        public bool ExpandSubscription { get; set; }

        public virtual Invoice Create(InvoiceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}", requestOptions, options);
        }

        public virtual Invoice Get(string invoiceId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{invoiceId}", requestOptions);
        }

        public virtual StripeList<Invoice> List(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual StripeList<InvoiceLineItem> ListLineItems(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetRequest<StripeList<InvoiceLineItem>>($"{classUrl}/{invoiceId}/lines", listOptions, requestOptions);
        }

        public virtual StripeList<InvoiceLineItem> ListUpcomingLineItems(UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetRequest<StripeList<InvoiceLineItem>>($"{classUrl}/upcoming/lines", listOptions, requestOptions);
        }

        public virtual Invoice Pay(string invoiceId, InvoicePayOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{invoiceId}/pay", requestOptions, options);
        }

        public virtual Invoice Upcoming(UpcomingInvoiceOptions options, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/upcoming", requestOptions, options);
        }

        public virtual Invoice Update(string invoiceId, InvoiceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{invoiceId}", requestOptions, options);
        }

        public virtual Task<Invoice> CreateAsync(InvoiceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Invoice> GetAsync(string invoiceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{invoiceId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Invoice>> ListAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetRequestAsync<StripeList<InvoiceLineItem>>($"{classUrl}/{invoiceId}/lines", listOptions, requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListUpcomingLineItemsAsync(UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetRequestAsync<StripeList<InvoiceLineItem>>($"{classUrl}/upcoming/lines", listOptions, requestOptions, cancellationToken);
        }

        public virtual Task<Invoice> PayAsync(string invoiceId, InvoicePayOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{invoiceId}/pay", requestOptions, cancellationToken, options);
        }

        public virtual Task<Invoice> UpcomingAsync(UpcomingInvoiceOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/upcoming", requestOptions, cancellationToken, options);
        }

        public virtual Task<Invoice> UpdateAsync(string invoiceId, InvoiceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{invoiceId}", requestOptions, cancellationToken, options);
        }
    }
}

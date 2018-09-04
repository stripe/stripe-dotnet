namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class InvoiceService : StripeService,
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

        public virtual Invoice Create(InvoiceCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Invoice> CreateAsync(InvoiceCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Invoice Get(string invoiceId, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Invoice> GetAsync(string invoiceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<Invoice> List(InvoiceListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Invoice>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<Invoice>> ListAsync(InvoiceListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Invoice>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<InvoiceLineItem> ListLineItems(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{classUrl}/{invoiceId}/lines", true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{classUrl}/{invoiceId}/lines", true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<InvoiceLineItem> ListUpcomingLineItems(UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{classUrl}/upcoming/lines", true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<InvoiceLineItem>> ListUpcomingLineItemsAsync(UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{classUrl}/upcoming/lines", true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Invoice Pay(string invoiceId, InvoicePayOptions payOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(payOptions, $"{classUrl}/{invoiceId}/pay", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Invoice> PayAsync(string invoiceId, InvoicePayOptions payOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(payOptions, $"{classUrl}/{invoiceId}/pay", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Invoice Upcoming(UpcomingInvoiceOptions upcomingOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(upcomingOptions, $"{classUrl}/upcoming", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Invoice> UpcomingAsync(UpcomingInvoiceOptions upcomingOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(upcomingOptions, $"{classUrl}/upcoming", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Invoice Update(string invoiceId, InvoiceUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Invoice> UpdateAsync(string invoiceId, InvoiceUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class InvoiceService : StripeService
    {
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

        public virtual Invoice Get(string invoiceId, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Invoice Upcoming(string customerId, UpcomingInvoiceOptions upcomingOptions = null, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

            return Mapper<Invoice>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(upcomingOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Invoice Update(string invoiceId, InvoiceUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Invoice Pay(string invoiceId, InvoicePayOptions payOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Invoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(payOptions, $"{Urls.Invoices}/{invoiceId}/pay", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Invoice> List(InvoiceListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Invoice>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Invoices, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<InvoiceLineItem> ListLineItems(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.Invoices}/{invoiceId}/lines", true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<InvoiceLineItem> ListUpcomingLineItems(string customerId, UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming/lines", "customer", customerId);

            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Invoice Create(string customerId, InvoiceCreateOptions createOptions = null, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<Invoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Invoice> GetAsync(string invoiceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Invoice> UpcomingAsync(string customerId, UpcomingInvoiceOptions upcomingOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

            return Mapper<Invoice>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(upcomingOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Invoice> UpdateAsync(string invoiceId, InvoiceUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Invoice> PayAsync(string invoiceId, InvoicePayOptions payOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Invoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(payOptions, $"{Urls.Invoices}/{invoiceId}/pay", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Invoice>> ListAsync(InvoiceListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Invoice>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Invoices, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.Invoices}/{invoiceId}/lines", true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<InvoiceLineItem>> ListUpcomingLineItemsAsync(string customerId, UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming/lines", "customer", customerId);

            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Invoice> CreateAsync(string customerId, InvoiceCreateOptions createOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<Invoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

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

        public virtual StripeInvoice Get(string invoiceId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeInvoice Upcoming(string customerId, UpcomingInvoiceOptions upcomingOptions = null, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(upcomingOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeInvoice Update(string invoiceId, InvoiceUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeInvoice Pay(string invoiceId, InvoicePayOptions payOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(payOptions, $"{Urls.Invoices}/{invoiceId}/pay", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeInvoice> List(InvoiceListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeInvoice>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Invoices, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeInvoiceLineItem> ListLineItems(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeInvoiceLineItem>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.Invoices}/{invoiceId}/lines", true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeInvoiceLineItem> ListUpcomingLineItems(string customerId, UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming/lines", "customer", customerId);

            return Mapper<StripeList<StripeInvoiceLineItem>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeInvoice Create(string customerId, InvoiceCreateOptions createOptions = null, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeInvoice> GetAsync(string invoiceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeInvoice> UpcomingAsync(string customerId, UpcomingInvoiceOptions upcomingOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(upcomingOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeInvoice> UpdateAsync(string invoiceId, InvoiceUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Invoices}/{invoiceId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeInvoice> PayAsync(string invoiceId, InvoicePayOptions payOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(payOptions, $"{Urls.Invoices}/{invoiceId}/pay", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeInvoice>> ListAsync(InvoiceListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeInvoice>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Invoices, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeInvoiceLineItem>> ListLineItemsAsync(string invoiceId, InvoiceListLineItemsOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeInvoiceLineItem>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.Invoices}/{invoiceId}/lines", true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeInvoiceLineItem>> ListUpcomingLineItemsAsync(string customerId, UpcomingInvoiceOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming/lines", "customer", customerId);

            return Mapper<StripeList<StripeInvoiceLineItem>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeInvoice> CreateAsync(string customerId, InvoiceCreateOptions createOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

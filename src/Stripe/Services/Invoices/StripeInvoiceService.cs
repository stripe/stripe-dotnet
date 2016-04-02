using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeInvoiceService : StripeService
    {
        public StripeInvoiceService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandCustomer { get; set; }

        public virtual StripeInvoice Get(string invoiceId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoice Upcoming(string customerId, StripeUpcomingInvoiceOptions upcomingOptions = null, StripeRequestOptions requestOptions = null)
        {
            url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(upcomingOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoice Update(string invoiceId, StripeInvoiceUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Invoices}/{invoiceId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoice Pay(string invoiceId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}/pay", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeInvoice> List(StripeInvoiceListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Invoices, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoice Create(string customerId, StripeInvoiceCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeInvoice> GetAsync(string invoiceId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeInvoice> UpcomingAsync(string customerId, StripeUpcomingInvoiceOptions upcomingOptions = null, StripeRequestOptions requestOptions = null)
        {
            url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(upcomingOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeInvoice> UpdateAsync(string invoiceId, StripeInvoiceUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Invoices}/{invoiceId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeInvoice> PayAsync(string invoiceId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}/pay", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeInvoice>> ListAsync(StripeInvoiceListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Invoices, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeInvoice> CreateAsync(string customerId, StripeInvoiceCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}

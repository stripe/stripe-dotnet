using System;
using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeInvoiceService : StripeService
    {
        public StripeInvoiceService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandCustomer { get; set; }

        public virtual StripeInvoice Get(string invoiceId)
        {
            var url = FormatGetUrl(invoiceId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoice> GetAsync(string invoiceId)
        {
            var url = FormatGetUrl(invoiceId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
#endif

        public virtual StripeInvoice Upcoming(string customerId, string subscriptionId = null)
        {
            var url = FormatUpcomingUrl(customerId, subscriptionId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoice> UpcomingAsync(string customerId, string subscriptionId = null)
        {
            var url = FormatUpcomingUrl(customerId, subscriptionId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
#endif
        
        public virtual StripeInvoice Update(string invoiceId, StripeInvoiceUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(invoiceId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoice> UpdateAsync(string invoiceId, StripeInvoiceUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(invoiceId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
#endif

        public virtual StripeInvoice Pay(string invoiceId)
        {
            var url = FormatPayUrl(invoiceId);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoice> PayAsync(string invoiceId)
        {
            var url = FormatPayUrl(invoiceId);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
#endif

        public virtual IEnumerable<StripeInvoice> List(StripeInvoiceListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeInvoice>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeInvoice>> ListAsync(StripeInvoiceListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapCollectionFromJson(response);
        }
#endif

        public virtual StripeInvoice Create(string customerId)
        {
            var url = FormatCreateUrl(customerId);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoice> CreateAsync(string customerId)
        {
            var url = FormatCreateUrl(customerId);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
#endif

        private static string FormatGetUrl(string invoiceId)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
            return url;
        }

        private static string FormatUpcomingUrl(string customerId, string subscriptionId)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, "upcoming");

            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            if (!String.IsNullOrEmpty(subscriptionId))
                url = ParameterBuilder.ApplyParameterToUrl(url, "subscription", subscriptionId);
            return url;
        }

        private string FormatUpdateUrl(string invoiceId, StripeInvoiceUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
            url = this.ApplyAllParameters(updateOptions, url, false);
            return url;
        }
        
        private string FormatPayUrl(string invoiceId)
        {
            var url = string.Format("{0}/{1}/pay", Urls.Invoices, invoiceId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatListUrl(StripeInvoiceListOptions listOptions)
        {
            var url = Urls.Invoices;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private static string FormatCreateUrl(string customerId)
        {
            var url = Urls.Invoices;
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);
            return url;
        }
    }
}
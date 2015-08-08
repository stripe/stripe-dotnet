using System;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeInvoiceService : StripeService
    {
        public StripeInvoiceService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandCustomer { get; set; }

        public virtual StripeInvoice Get(string invoiceId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual StripeInvoice Upcoming(string customerId, string subscriptionId = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Invoices, "upcoming");

            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            if(!String.IsNullOrEmpty(subscriptionId))
                url = ParameterBuilder.ApplyParameterToUrl(url, "subscription", subscriptionId);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual StripeInvoice Update(string invoiceId, StripeInvoiceUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual StripeInvoice Pay(string invoiceId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}/pay", Urls.Invoices, invoiceId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeInvoice> List(StripeInvoiceListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.Invoices;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeInvoice>.MapCollectionFromJson(response);
        }

        public virtual StripeInvoice Create(string customerId, StripeInvoiceCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.Invoices;
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);
            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
    }
}
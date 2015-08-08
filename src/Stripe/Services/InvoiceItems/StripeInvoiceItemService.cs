using System.Collections.Generic;

namespace Stripe
{
    public class StripeInvoiceItemService : StripeService
    {
        public StripeInvoiceItemService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandInvoice { get; set; }

        public virtual StripeInvoiceLineItem Create(StripeInvoiceItemCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }

        public virtual StripeInvoiceLineItem Get(string invoiceItemId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }

        public virtual StripeInvoiceLineItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }

        public virtual void Delete(string invoiceItemId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

            Requestor.Delete(url, requestOptions);
        }

        public virtual IEnumerable<StripeInvoiceLineItem> List(StripeInvoiceItemListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.InvoiceItems;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(response);
        }
    }
}
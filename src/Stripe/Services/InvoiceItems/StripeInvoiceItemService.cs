using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeInvoiceItemService : StripeService
    {
        public StripeInvoiceItemService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandInvoice { get; set; }

        public virtual StripeInvoiceLineItem Create(StripeInvoiceItemCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoiceLineItem> CreateAsync(StripeInvoiceItemCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }
#endif

        public virtual StripeInvoiceLineItem Get(string invoiceItemId)
        {
            var url = FormatGetUrl(invoiceItemId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoiceLineItem> GetAsync(string invoiceItemId)
        {
            var url = FormatGetUrl(invoiceItemId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }
#endif

        public virtual StripeInvoiceLineItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(invoiceItemId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeInvoiceLineItem> UpdateAsync(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(invoiceItemId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapFromJson(response);
        }
#endif

        public virtual void Delete(string invoiceItemId)
        {
            var url = FormatDeleteUrl(invoiceItemId);

            Requestor.Delete(url, ApiKey);
        }

#if NET40
        public virtual async Task DeleteAsync(string invoiceItemId)
        {
            var url = FormatDeleteUrl(invoiceItemId);

            await Requestor.DeleteAsync(url, ApiKey);
        }
#endif

        public virtual IEnumerable<StripeInvoiceLineItem> List(StripeInvoiceItemListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeInvoiceLineItem>> ListAsync(StripeInvoiceItemListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(response);
        }
#endif
        
        private string FormatListUrl(StripeInvoiceItemListOptions listOptions)
        {
            var url = Urls.InvoiceItems;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatGetUrl(string invoiceItemId)
        {
            var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatUpdateUrl(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
            url = this.ApplyAllParameters(updateOptions, url, false);
            return url;
        }

        private static string FormatDeleteUrl(string invoiceItemId)
        {
            var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
            return url;
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeInvoiceItemService : StripeService
    {
        public StripeInvoiceItemService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandInvoice { get; set; }

        public virtual StripeInvoiceItem Create(StripeInvoiceItemCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapFromJson(response);
        }

        public virtual async Task<StripeInvoiceItem> CreateAsync(StripeInvoiceItemCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapFromJson(response);
        }

        public virtual StripeInvoiceItem Get(string invoiceItemId)
        {
            var url = FormatGetUrl(invoiceItemId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapFromJson(response);
        }

        public virtual async Task<StripeInvoiceItem> GetAsync(string invoiceItemId)
        {
            var url = FormatGetUrl(invoiceItemId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapFromJson(response);
        }

        public virtual StripeInvoiceItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(invoiceItemId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapFromJson(response);
        }

        public virtual async Task<StripeInvoiceItem> UpdateAsync(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(invoiceItemId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapFromJson(response);
        }

        public virtual void Delete(string invoiceItemId)
        {
            var url = FormatDeleteUrl(invoiceItemId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual async Task DeleteAsync(string invoiceItemId)
        {
            var url = FormatDeleteUrl(invoiceItemId);

            await Requestor.DeleteAsync(url, ApiKey);
        }

        public virtual IEnumerable<StripeInvoiceItem> List(StripeInvoiceItemListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapCollectionFromJson(response);
        }

        public virtual async Task<IEnumerable<StripeInvoiceItem>> ListAsync(StripeInvoiceItemListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoiceItem>.MapCollectionFromJson(response);
        }
        
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
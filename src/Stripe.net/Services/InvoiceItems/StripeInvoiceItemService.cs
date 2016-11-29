using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeInvoiceItemService : StripeService
    {
        public StripeInvoiceItemService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandInvoice { get; set; }



        //Sync
        public virtual StripeInvoiceLineItem Create(StripeInvoiceItemCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoiceLineItem>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoiceLineItem Get(string invoiceItemId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoiceLineItem>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoiceLineItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoiceLineItem>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string invoiceItemId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete($"{Urls.InvoiceItems}/{invoiceItemId}",
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeInvoiceLineItem> List(StripeInvoiceItemListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.InvoiceItems, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeInvoiceLineItem> CreateAsync(StripeInvoiceItemCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoiceLineItem>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeInvoiceLineItem> GetAsync(string invoiceItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoiceLineItem>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeInvoiceLineItem> UpdateAsync(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoiceLineItem>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string invoiceItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync($"{Urls.InvoiceItems}/{invoiceItemId}",
                SetupRequestOptions(requestOptions),
                cancellationToken)
                );
        }

        public virtual async Task<IEnumerable<StripeInvoiceLineItem>> ListAsync(StripeInvoiceItemListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.InvoiceItems, true),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}

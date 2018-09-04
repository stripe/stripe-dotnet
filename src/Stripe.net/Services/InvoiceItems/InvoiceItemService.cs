namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class InvoiceItemService : StripeService,
        ICreatable<InvoiceLineItem, InvoiceItemCreateOptions>,
        IDeletable<InvoiceLineItem>,
        IListable<InvoiceLineItem, InvoiceItemListOptions>,
        IRetrievable<InvoiceLineItem>,
        IUpdatable<InvoiceLineItem, InvoiceItemUpdateOptions>
    {
        public InvoiceItemService()
            : base(null)
        {
        }

        public InvoiceItemService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public bool ExpandInvoice { get; set; }

        public bool ExpandSubscription { get; set; }

        public virtual InvoiceLineItem Create(InvoiceItemCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual InvoiceLineItem Get(string invoiceItemId, RequestOptions requestOptions = null)
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual InvoiceLineItem Update(string invoiceItemId, InvoiceItemUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual InvoiceLineItem Delete(string invoiceItemId, RequestOptions requestOptions = null)
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                Requestor.Delete(
                    $"{Urls.InvoiceItems}/{invoiceItemId}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<InvoiceLineItem> List(InvoiceItemListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.InvoiceItems, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<InvoiceLineItem> CreateAsync(InvoiceItemCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<InvoiceLineItem> GetAsync(string invoiceItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<InvoiceLineItem> UpdateAsync(string invoiceItemId, InvoiceItemUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.InvoiceItems}/{invoiceItemId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<InvoiceLineItem> DeleteAsync(string invoiceItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<InvoiceLineItem>.MapFromJson(
                await Requestor.DeleteAsync(
                    $"{Urls.InvoiceItems}/{invoiceItemId}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<InvoiceLineItem>> ListAsync(InvoiceItemListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<InvoiceLineItem>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.InvoiceItems, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeInvoiceService : StripeService
    {
        public StripeInvoiceService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandCustomer { get; set; }



        //Sync
        public virtual StripeInvoice Get(string invoiceId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoice Upcoming(string customerId, StripeUpcomingInvoiceOptions upcomingOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

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

        public virtual IEnumerable<StripeInvoiceLineItem> ListLineItems(string invoiceId, StripeInvoiceListLineItemsOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, $"{Urls.Invoices}/{invoiceId}/lines", true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeInvoiceLineItem> ListUpcomingLineItems(string customerId, StripeUpcomingInvoiceOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming/lines", "customer", customerId);

            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeInvoice Create(string customerId, StripeInvoiceCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeInvoice> GetAsync(string invoiceId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeInvoice> UpcomingAsync(string customerId, StripeUpcomingInvoiceOptions upcomingOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming", "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(upcomingOptions, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeInvoice> UpdateAsync(string invoiceId, StripeInvoiceUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Invoices}/{invoiceId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeInvoice> PayAsync(string invoiceId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(null, $"{Urls.Invoices}/{invoiceId}/pay", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<IEnumerable<StripeInvoice>> ListAsync(StripeInvoiceListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoice>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Invoices, true),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<IEnumerable<StripeInvoiceLineItem>> ListLineItemsAsync(string invoiceId, StripeInvoiceListLineItemsOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.Invoices}/{invoiceId}/lines", true),
                    SetupRequestOptions(requestOptions), 
                    cancellationToken)
            );
        }

        public virtual async Task<IEnumerable<StripeInvoiceLineItem>> ListUpcomingLineItemsAsync(string customerId, StripeUpcomingInvoiceOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.Invoices}/upcoming/lines", "customer", customerId);

            return Mapper<StripeInvoiceLineItem>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeInvoice> CreateAsync(string customerId, StripeInvoiceCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.Invoices, "customer", customerId);

            return Mapper<StripeInvoice>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, url),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}

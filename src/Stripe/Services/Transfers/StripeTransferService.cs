using System.Collections.Generic;

namespace Stripe
{
    public class StripeTransferService : StripeService
    {
        public StripeTransferService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeTransfer Create(StripeTransferCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.Transfers, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

        public virtual StripeTransfer Get(string transferId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Transfers, transferId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

        public virtual StripeTransfer Cancel(string transferId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}/cancel", Urls.Transfers, transferId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeTransfer> List(StripeTransferListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.Transfers;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeTransfer>.MapCollectionFromJson(response);
        }
    }
}
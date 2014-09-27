using System.Collections.Generic;

namespace Stripe
{
    public class StripeTransferService : StripeService
    {
        public StripeTransferService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeTransfer Create(StripeTransferCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Transfers, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

        public virtual StripeTransfer Get(string transferId)
        {
            var url = string.Format("{0}/{1}", Urls.Transfers, transferId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

        public virtual StripeTransfer Cancel(string transferId)
        {
            var url = string.Format("{0}/{1}/cancel", Urls.Transfers, transferId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeTransfer> List(StripeTransferListOptions listOptions = null)
        {
            var url = Urls.Transfers;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeTransfer>.MapCollectionFromJson(response);
        }
    }
}
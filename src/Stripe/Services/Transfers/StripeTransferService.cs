using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

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

#if NET40
        public virtual async Task<StripeTransfer> CreateAsync(StripeTransferCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Transfers, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }
#endif

        public virtual StripeTransfer Get(string transferId)
        {
            var url = FormatGetUrl(transferId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeTransfer> GetAsync(string transferId)
        {
            var url = FormatGetUrl(transferId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }
#endif
        
        public virtual StripeTransfer Cancel(string transferId)
        {
            var url = FormatCancelUrl(transferId);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeTransfer> CancelAsync(string transferId)
        {
            var url = FormatCancelUrl(transferId);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }
#endif
        
        public virtual IEnumerable<StripeTransfer> List(StripeTransferListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeTransfer>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeTransfer>> ListAsync(StripeTransferListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeTransfer>.MapCollectionFromJson(response);
        }
#endif

        private string FormatListUrl(StripeTransferListOptions listOptions)
        {
            var url = Urls.Transfers;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatGetUrl(string transferId)
        {
            var url = string.Format("{0}/{1}", Urls.Transfers, transferId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatCancelUrl(string transferId)
        {
            var url = string.Format("{0}/{1}/cancel", Urls.Transfers, transferId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }
    }
}
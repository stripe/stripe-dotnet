using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeTransferService : StripeService
    {
        public StripeTransferService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeTransfer Create(StripeTransferCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Transfers, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeTransfer Get(string transferId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Transfers}/{transferId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeTransfer Cancel(string transferId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(null, $"{Urls.Transfers}/{transferId}/cancel", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeTransfer> List(StripeTransferListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Transfers, true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeTransfer> CreateAsync(StripeTransferCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Transfers, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeTransfer> GetAsync(string transferId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Transfers}/{transferId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeTransfer> CancelAsync(string transferId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(null, $"{Urls.Transfers}/{transferId}/cancel", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeTransfer>> ListAsync(StripeTransferListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransfer>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Transfers, true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}

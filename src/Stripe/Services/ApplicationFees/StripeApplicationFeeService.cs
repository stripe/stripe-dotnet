using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeApplicationFeeService : StripeService
    {
        public StripeApplicationFeeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandAccount { get; set; }
        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCharge { get; set; }

        public virtual StripeApplicationFee Get(string applicationFeeId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFee>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeApplicationFee Refund(string applicationFeeId, int? refundAmount = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

            return Mapper<StripeApplicationFee>.MapFromJson(
                Requestor.PostString(url, SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeApplicationFee> List(StripeApplicationFeeListOptions listOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFee>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeApplicationFee> GetAsync(string applicationFeeId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFee>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeApplicationFee> RefundAsync(string applicationFeeId, int? refundAmount = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

            return Mapper<StripeApplicationFee>.MapFromJson(
                await Requestor.PostStringAsync(url, SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeApplicationFee>> ListAsync(StripeApplicationFeeListOptions listOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFee>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}

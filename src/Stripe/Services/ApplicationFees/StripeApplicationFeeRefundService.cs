using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeApplicationFeeRefundService : StripeService
    {
        public StripeApplicationFeeRefundService(string apiKey = null) : base(apiKey)
        {
        }

        public virtual StripeApplicationFeeRefund Get(string applicationFeeId, string applicationFeeRefundId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFeeRefund>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refunds/{applicationFeeRefundId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeApplicationFeeRefund> List(string applicationFeeId, StripeListOptions listOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFeeRefund>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, $"{Urls.ApplicationFees}/{applicationFeeId}/refunds", true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeApplicationFeeRefund Refund(string applicationFeeId, int? refundAmount = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refunds", false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

            return Mapper<StripeApplicationFeeRefund>.MapFromJson(
                Requestor.PostString(url, SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE

        public virtual async Task<StripeApplicationFeeRefund> GetAsync(string applicationFeeId, string applicationFeeRefundId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFeeRefund>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refunds/{applicationFeeRefundId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeApplicationFeeRefund>> ListAsync(string applicationFeeId, StripeListOptions listOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFeeRefund>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, $"{Urls.ApplicationFees}/{applicationFeeId}/refunds", true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeApplicationFeeRefund> RefundAsync(string applicationFeeId, int? refundAmount = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refunds", false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

            return Mapper<StripeApplicationFeeRefund>.MapFromJson(
                await Requestor.PostStringAsync(url, SetupRequestOptions(requestOptions))
            );
        }

#endif
    }
}
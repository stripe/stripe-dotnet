using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeApplicationFeeService : StripeService
    {
        public StripeApplicationFeeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandAccount { get; set; }
        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCharge { get; set; }

        public virtual StripeApplicationFee Get(string applicationFeeId)
        {
            var url = FormatGetUrl(applicationFeeId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeApplicationFee> GetAsync(string applicationFeeId)
        {
            var url = FormatGetUrl(applicationFeeId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapFromJson(response);
        }
#endif

        public virtual StripeApplicationFee Refund(string applicationFeeId, int? refundAmount = null)
        {
            var url = FormatRefundUrl(applicationFeeId, refundAmount);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeApplicationFee> RefundAsync(string applicationFeeId, int? refundAmount = null)
        {
            var url = FormatRefundUrl(applicationFeeId, refundAmount);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapFromJson(response);
        }
#endif

        public virtual IEnumerable<StripeApplicationFee> List(StripeApplicationFeeListOptions listOptions)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeApplicationFee>> ListAsync(StripeApplicationFeeListOptions listOptions)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapCollectionFromJson(response);
        }
#endif

        private string FormatListUrl(StripeApplicationFeeListOptions listOptions)
        {
            var url = Urls.ApplicationFees;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }
        
        private string FormatGetUrl(string applicationFeeId)
        {
            var url = string.Format("{0}/{1}", Urls.ApplicationFees, applicationFeeId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatRefundUrl(string applicationFeeId, int? refundAmount)
        {
            var url = string.Format("{0}/{1}/refund", Urls.ApplicationFees, applicationFeeId);
            url = this.ApplyAllParameters(null, url, false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
            return url;
        }
    }
}
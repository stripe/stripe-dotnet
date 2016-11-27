using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeApplicationFeeService : StripeBasicService<StripeApplicationFee>
    {
        public StripeApplicationFeeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandAccount { get; set; }
        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCharge { get; set; }



        //Sync
        public virtual StripeApplicationFee Get(string applicationFeeId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/application_fees/{applicationFeeId}", requestOptions);
        }

        // obsolete: use StripeApplicationFeeRefundService instead.
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
            return GetEntityList($"{Urls.BaseUrl}/application_fees", requestOptions, listOptions);
        }



        //Async
        public virtual async Task<StripeApplicationFee> GetAsync(string applicationFeeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}", requestOptions, cancellationToken);
        }

        // obsolete: use StripeApplicationFeeRefundService instead.
        public virtual async Task<StripeApplicationFee> RefundAsync(string applicationFeeId, int? refundAmount = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

            return Mapper<StripeApplicationFee>.MapFromJson(
                await Requestor.PostStringAsync(url, SetupRequestOptions(requestOptions), cancellationToken)
            );
        }

        public virtual async Task<IEnumerable<StripeApplicationFee>> ListAsync(StripeApplicationFeeListOptions listOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/application_fees", requestOptions, cancellationToken, listOptions);
        }
    }
}

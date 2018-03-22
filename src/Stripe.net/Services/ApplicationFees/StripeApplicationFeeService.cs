using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeApplicationFeeService : StripeService
    {
        public StripeApplicationFeeService() : base(null) { }
        public StripeApplicationFeeService(string apiKey) : base(apiKey) { }

        public bool ExpandAccount { get; set; }
        public bool ExpandApplication { get; set; }
        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCharge { get; set; }
        public bool ExpandOriginatingTransaction { get; set; }



        //Sync
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

        public virtual StripeList<StripeApplicationFee> List(StripeApplicationFeeListOptions listOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeApplicationFee>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeApplicationFee> GetAsync(string applicationFeeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeApplicationFee>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeApplicationFee> RefundAsync(string applicationFeeId, int? refundAmount = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

            return Mapper<StripeApplicationFee>.MapFromJson(
                await Requestor.PostStringAsync(url, SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeApplicationFee>> ListAsync(StripeApplicationFeeListOptions listOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeApplicationFee>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                SetupRequestOptions(requestOptions), 
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}

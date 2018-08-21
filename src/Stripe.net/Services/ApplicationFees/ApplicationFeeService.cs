namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ApplicationFeeService : StripeService
    {
        public ApplicationFeeService()
            : base(null)
        {
        }

        public ApplicationFeeService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandAccount { get; set; }

        public bool ExpandApplication { get; set; }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCharge { get; set; }

        public bool ExpandOriginatingTransaction { get; set; }

        public virtual StripeApplicationFee Get(string applicationFeeId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeApplicationFee>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeApplicationFee Refund(string applicationFeeId, int? refundAmount = null, RequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
            }

            return Mapper<StripeApplicationFee>.MapFromJson(
                Requestor.PostString(url, this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeApplicationFee> List(ApplicationFeeListOptions listOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeApplicationFee>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeApplicationFee> GetAsync(string applicationFeeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeApplicationFee>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeApplicationFee> RefundAsync(string applicationFeeId, int? refundAmount = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
            }

            return Mapper<StripeApplicationFee>.MapFromJson(
                await Requestor.PostStringAsync(url, this.SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeApplicationFee>> ListAsync(ApplicationFeeListOptions listOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeApplicationFee>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

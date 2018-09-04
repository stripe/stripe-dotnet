namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ApplicationFeeService : StripeService,
        IListable<ApplicationFee, ApplicationFeeListOptions>,
        IRetrievable<ApplicationFee>
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

        public virtual ApplicationFee Get(string applicationFeeId, RequestOptions requestOptions = null)
        {
            return Mapper<ApplicationFee>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual ApplicationFee Refund(string applicationFeeId, int? refundAmount = null, RequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
            }

            return Mapper<ApplicationFee>.MapFromJson(
                Requestor.PostString(url, this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<ApplicationFee> List(ApplicationFeeListOptions listOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<ApplicationFee>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<ApplicationFee> GetAsync(string applicationFeeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<ApplicationFee>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<ApplicationFee> RefundAsync(string applicationFeeId, int? refundAmount = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(null, $"{Urls.ApplicationFees}/{applicationFeeId}/refund", false);

            if (refundAmount.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
            }

            return Mapper<ApplicationFee>.MapFromJson(
                await Requestor.PostStringAsync(url, this.SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<ApplicationFee>> ListAsync(ApplicationFeeListOptions listOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<ApplicationFee>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.ApplicationFees, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

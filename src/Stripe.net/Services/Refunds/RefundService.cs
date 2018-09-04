namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class RefundService : StripeService,
        ICreatable<Refund, RefundCreateOptions>,
        IListable<Refund, RefundListOptions>,
        IRetrievable<Refund>,
        IUpdatable<Refund, RefundUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/refunds";

        public RefundService()
            : base(null)
        {
        }

        public RefundService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCharge { get; set; }

        public bool ExpandFailureBalanceTransaction { get; set; }

        public virtual Refund Create(RefundCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Refund>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Refund> CreateAsync(RefundCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Refund>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Refund Get(string refundId, RequestOptions requestOptions = null)
        {
            return Mapper<Refund>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{refundId}"),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Refund> GetAsync(string refundId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Refund>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{refundId}"),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual StripeList<Refund> List(RefundListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Refund>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<Refund>> ListAsync(RefundListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Refund>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Refund Update(string refundId, RefundUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Refund>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{refundId}"),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Refund> UpdateAsync(string refundId, RefundUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Refund>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{refundId}"),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

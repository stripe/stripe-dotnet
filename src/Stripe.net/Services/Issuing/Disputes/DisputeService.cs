namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DisputeService : StripeService,
        ICreatable<Dispute, DisputeCreateOptions>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/disputes";

        public DisputeService()
            : base(null)
        {
        }

        public DisputeService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Dispute Create(DisputeCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Dispute>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Dispute Update(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Dispute>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{disputeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Dispute Get(string disputeId, RequestOptions requestOptions = null)
        {
            return Mapper<Dispute>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{disputeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Dispute> List(DisputeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Dispute>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Dispute> CreateAsync(DisputeCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Dispute>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Dispute> UpdateAsync(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Dispute>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{disputeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Dispute> GetAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Dispute>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{disputeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Dispute>> ListAsync(DisputeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Dispute>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public partial class StripeSubscriptionService : StripeService
    {
        public StripeSubscriptionService()
            : base(null)
        {
        }

        public StripeSubscriptionService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public virtual StripeSubscription Get(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeSubscription Create(StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Subscriptions, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeSubscription Update(string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeSubscription Cancel(string subscriptionId, StripeSubscriptionCancelOptions cancelOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(cancelOptions, $"{Urls.Subscriptions}/{WebUtility.UrlEncode(subscriptionId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeSubscription> List(StripeSubscriptionListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeSubscription>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeSubscription> GetAsync(string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeSubscription> CreateAsync(StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Subscriptions, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeSubscription> UpdateAsync(string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeSubscription> CancelAsync(string subscriptionId, StripeSubscriptionCancelOptions cancelOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);
            this.ApplyAllParameters(cancelOptions, url, false);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.DeleteAsync(
                    url,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeSubscription>> ListAsync(StripeSubscriptionListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeSubscription>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

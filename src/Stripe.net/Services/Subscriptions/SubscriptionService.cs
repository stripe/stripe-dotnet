namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public partial class SubscriptionService : StripeService
    {
        public SubscriptionService()
            : base(null)
        {
        }

        public SubscriptionService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public virtual StripeSubscription Get(string subscriptionId, RequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeSubscription Create(SubscriptionCreateOptions createOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Subscriptions, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeSubscription Update(string subscriptionId, SubscriptionUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeSubscription Cancel(string subscriptionId, SubscriptionCancelOptions cancelOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(cancelOptions, $"{Urls.Subscriptions}/{WebUtility.UrlEncode(subscriptionId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeSubscription> List(SubscriptionListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeSubscription>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeSubscription> GetAsync(string subscriptionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeSubscription> CreateAsync(SubscriptionCreateOptions createOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Subscriptions, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeSubscription> UpdateAsync(string subscriptionId, SubscriptionUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeSubscription> CancelAsync(string subscriptionId, SubscriptionCancelOptions cancelOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);
            this.ApplyAllParameters(cancelOptions, url, false);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.DeleteAsync(
                    url,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeSubscription>> ListAsync(SubscriptionListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeSubscription>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

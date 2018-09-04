namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public partial class SubscriptionService : StripeService,
        ICreatable<Subscription, SubscriptionCreateOptions>,
        IListable<Subscription, SubscriptionListOptions>,
        IRetrievable<Subscription>,
        IUpdatable<Subscription, SubscriptionUpdateOptions>
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

        public virtual Subscription Get(string subscriptionId, RequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<Subscription>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Subscription Create(SubscriptionCreateOptions createOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<Subscription>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Subscriptions, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Subscription Update(string subscriptionId, SubscriptionUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<Subscription>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Subscription Cancel(string subscriptionId, SubscriptionCancelOptions cancelOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Subscription>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(cancelOptions, $"{Urls.Subscriptions}/{WebUtility.UrlEncode(subscriptionId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Subscription> List(SubscriptionListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Subscription>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Subscription> GetAsync(string subscriptionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<Subscription>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Subscription> CreateAsync(SubscriptionCreateOptions createOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Subscription>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Subscriptions, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Subscription> UpdateAsync(string subscriptionId, SubscriptionUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<Subscription>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Subscription> CancelAsync(string subscriptionId, SubscriptionCancelOptions cancelOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);
            this.ApplyAllParameters(cancelOptions, url, false);

            return Mapper<Subscription>.MapFromJson(
                await Requestor.DeleteAsync(
                    url,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Subscription>> ListAsync(SubscriptionListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Subscription>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public partial class StripeSubscriptionService : StripeService
    {
        public StripeSubscriptionService() : base(null) { }
        public StripeSubscriptionService(string apiKey) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }



        //Sync
        public virtual StripeSubscription Get(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSubscription Create(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Subscriptions, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(ParameterBuilder.ApplyParameterToUrl(url, "plan", planId),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSubscription Create(string customerId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Subscriptions, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(
                    url,
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual StripeSubscription Update(string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSubscription Cancel(string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.Delete(url,
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeSubscription> List(StripeSubscriptionListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeSubscription>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeSubscription> GetAsync(string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeSubscription> CreateAsync(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Subscriptions, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(ParameterBuilder.ApplyParameterToUrl(url, "plan", planId),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeSubscription> CreateAsync(string customerId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Subscriptions, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(
                    url,
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                ).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeSubscription> UpdateAsync(string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeSubscription> CancelAsync(string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.DeleteAsync(url,
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeSubscription>> ListAsync(StripeSubscriptionListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeSubscription>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}

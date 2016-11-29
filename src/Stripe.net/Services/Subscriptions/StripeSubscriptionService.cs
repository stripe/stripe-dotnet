using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionService : StripeService
    {
        public StripeSubscriptionService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }



        //Sync
        public virtual StripeSubscription Get(string customerId, string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSubscription Create(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(ParameterBuilder.ApplyParameterToUrl(url, "plan", planId),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSubscription Update(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSubscription Cancel(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.Delete(url,
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeSubscription> List(string customerId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions, customerId);

            return Mapper<StripeSubscription>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeSubscription> GetAsync(string customerId, string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeSubscription> CreateAsync(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(ParameterBuilder.ApplyParameterToUrl(url, "plan", planId),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeSubscription> UpdateAsync(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeSubscription> CancelAsync(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.DeleteAsync(url,
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<IEnumerable<StripeSubscription>> ListAsync(string customerId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.Subscriptions, customerId);

            return Mapper<StripeSubscription>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
   }
}

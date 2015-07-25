using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSubscriptionService : StripeService
    {
        public StripeSubscriptionService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }

        public virtual StripeSubscription Get(string customerId, string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Create(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "plan", planId);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Update(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Cancel(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            var response = Requestor.Delete(url, requestOptions);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeSubscription> List(string customerId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeSubscription>.MapCollectionFromJson(response);
        }
    }
}
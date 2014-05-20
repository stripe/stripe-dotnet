using Newtonsoft.Json;

namespace Stripe.Services.Subscriptions
{
    public class StripeSubscriptionService
    {
        private string ApiKey { get; set; }

        public StripeSubscriptionService(string apiKey = null)
        {
            ApiKey = apiKey;
        }
        public virtual StripeSubscription Get(string customerId, string subscriptionId)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Create(string customerId, StripeSubscriptionCreateOptions createOptions)
        {
            var url = string.Format(Urls.Subscriptions, customerId);
            url = ParameterBuilder.ApplyAllParameters(createOptions, url);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Update(string customerId, string subscriptionId, StripeSubscriptionCreateOptions updateOptions)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        /// <summary>
        /// Cancels the given subscription
        /// Note: subscriptionId is required if you have multiple subscriptions enabled
        /// </summary>
        public virtual StripeSubscription Cancel(string customerId, string subscriptionId = "", bool cancelAtPeriodEnd = false)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            var response = Requestor.Delete(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }
    }
}

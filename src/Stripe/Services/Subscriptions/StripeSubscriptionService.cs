using Newtonsoft.Json;
using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeSubscriptionService : StripeService
    {
        public StripeSubscriptionService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }

        public virtual StripeSubscription Get(string customerId, string subscriptionId)
        {
            var url = FormatGetUrl(customerId, subscriptionId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeSubscription> GetAsync(string customerId, string subscriptionId)
        {
            var url = FormatGetUrl(customerId, subscriptionId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }
#endif

        public virtual StripeSubscription Create(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null)
        {
            var url = FormatCreateUrl(customerId, planId, createOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeSubscription> CreateAsync(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null)
        {
            var url = FormatCreateUrl(customerId, planId, createOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }
#endif

        public virtual StripeSubscription Update(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(customerId, subscriptionId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeSubscription> UpdateAsync(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(customerId, subscriptionId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }
#endif

        public virtual StripeSubscription Cancel(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false)
        {
            var url = FormatCancelUrl(customerId, subscriptionId, cancelAtPeriodEnd);

            var response = Requestor.Delete(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeSubscription> CancelAsync(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false)
        {
            var url = FormatCancelUrl(customerId, subscriptionId, cancelAtPeriodEnd);

            var response = await Requestor.DeleteAsync(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }
#endif
        
        public virtual IEnumerable<StripeSubscription> List(string customerId, StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(customerId, listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeSubscription>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeSubscription>> ListAsync(string customerId, StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(customerId, listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeSubscription>.MapCollectionFromJson(response);
        }
#endif

        private string FormatListUrl(string customerId, StripeListOptions listOptions)
        {
            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatGetUrl(string customerId, string subscriptionId)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatCreateUrl(string customerId, string planId, StripeSubscriptionCreateOptions createOptions)
        {
            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "plan", planId);
            return url;
        }

        private string FormatUpdateUrl(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = this.ApplyAllParameters(updateOptions, url, false);
            return url;
        }

        private static string FormatCancelUrl(string customerId, string subscriptionId, bool cancelAtPeriodEnd)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());
            return url;
        }
    }
}
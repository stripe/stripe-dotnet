using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSubscriptionItemService : StripeBasicService<StripeSubscriptionItem>
    {
        public StripeSubscriptionItemService(string apiKey = null) : base(apiKey)
        {
        }

        public StripeSubscriptionItem Get(string subscriptionItemId, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format("{0}/{1}", Urls.SubscriptionItems, subscriptionItemId);
            return Mapper<StripeSubscriptionItem>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSubscriptionItem Create(string planId, string subscriptionId, StripeSubscriptionItemCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.SubscriptionItems, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "plan", planId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "subscription", subscriptionId);

            return Mapper<StripeSubscriptionItem>.MapFromJson(
                Requestor.PostString(url, SetupRequestOptions(requestOptions))
            );
        }

        public StripeSubscriptionItem Delete(string subscriptionItemId, StripeSubscriptionItemDeleteOptions deleteOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = Urls.SubscriptionItems + "/" + subscriptionItemId;
            url = this.ApplyAllParameters(deleteOptions, url, false);

            return Mapper<StripeSubscriptionItem>.MapFromJson(
                Requestor.Delete(url, SetupRequestOptions(requestOptions))
            );
        }

        public IEnumerable<StripeSubscriptionItem> List(string subscriptionId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(listOptions, Urls.SubscriptionItems, true);
            url = ParameterBuilder.ApplyParameterToUrl(url, "subscription", subscriptionId);
            return Mapper<StripeSubscriptionItem>.MapCollectionFromJson(
                Requestor.GetString(url, SetupRequestOptions(requestOptions))
            );
        }
    }
}

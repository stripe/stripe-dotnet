﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSubscriptionService : StripeService
    {
        public StripeSubscriptionService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }

        public virtual StripeSubscription Get(string customerId, string subscriptionId)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Create(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null)
        {
            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);
            url = ParameterBuilder.ApplyParameterToUrl(url, "plan", planId);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Update(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual StripeSubscription Cancel(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false)
        {
            var url = string.Format(Urls.Subscriptions + "/{1}", customerId, subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            var response = Requestor.Delete(url, ApiKey);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public virtual void DeleteSubscriptionDiscount(string customerId, string subscriptionId){
            var url = String.Format(Urls.SubscriptionDiscount, customerId, subscriptionId);
            var response = Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeSubscription> List(string customerId, StripeListOptions listOptions = null)
        {
            var url = string.Format(Urls.Subscriptions, customerId);
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeSubscription>.MapCollectionFromJson(response);
        }
    }
}
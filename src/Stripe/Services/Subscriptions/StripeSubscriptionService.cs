using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeSubscriptionService : StripeService
    {
        public StripeSubscriptionService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }

        [Obsolete("Get with customerId is deprecated, use Get without the customerId.")]
        public virtual StripeSubscription Get(string customerId, string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            return Get(subscriptionId, requestOptions);
        }

        public virtual StripeSubscription Get(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        [Obsolete("Create with customerId and planId is deprecated, use Create without the customerId planId by supplying those values in the StripeSubscriptionCreateOptions.")]
        public virtual StripeSubscription Create(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            if (createOptions == null)
              createOptions = new StripeSubscriptionCreateOptions();

            createOptions.CustomerId = customerId;
            createOptions.PlanId = planId;

            return Create(createOptions, requestOptions);
        }

        public virtual StripeSubscription Create(StripeSubscriptionCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Subscriptions, false);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(url,
                SetupRequestOptions(requestOptions))
            );
        }

        [Obsolete("Update with customerId is deprecated, use Update without the customerId.")]
        public virtual StripeSubscription Update(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Update(subscriptionId, updateOptions, requestOptions);
        }

        public virtual StripeSubscription Update(string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        [Obsolete("Cancel with customerId is deprecated, use Cancel without the customerId.")]
        public virtual StripeSubscription Cancel(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null)
        {
            return Cancel(subscriptionId, cancelAtPeriodEnd, requestOptions);
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

        public virtual IEnumerable<StripeSubscription> List(string customerId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format("/customers/{0}" + Urls.Subscriptions, customerId);

            return Mapper<StripeSubscription>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeSubscription> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSubscription>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                SetupRequestOptions(requestOptions))
            );
        }

        [Obsolete("GetAsync with customerId is deprecated, use GetAync without the customerId.")]
        public virtual async Task<StripeSubscription> GetAsync(string customerId, string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            return await GetAsync(subscriptionId, requestOptions);
        }

        public virtual async Task<StripeSubscription> GetAsync(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        [Obsolete("CreateAsync with customerId and planId is deprecated, use CreateAsync without the customerId planId by supplying those values in the StripeSubscriptionCreateOptions.")]
        public virtual async Task<StripeSubscription> CreateAsync(string customerId, string planId, StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            if (createOptions == null)
              createOptions = new StripeSubscriptionCreateOptions();

            createOptions.CustomerId = customerId;
            createOptions.PlanId = planId;

            return await CreateAsync(createOptions, requestOptions);
        }

        public virtual async Task<StripeSubscription> CreateAsync(StripeSubscriptionCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Subscriptions, false);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(url,
                SetupRequestOptions(requestOptions))
            );
        }

        [Obsolete("UpdateAsync with customerId is deprecated, use UpdateAsync without the customerId.")]
        public virtual async Task<StripeSubscription> UpdateAsync(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return await UpdateAsync(subscriptionId, updateOptions, requestOptions);
        }

        public virtual async Task<StripeSubscription> UpdateAsync(string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        [Obsolete("CancelAsync with customerId is deprecated, use CancelAsync without the customerId.")]
        public virtual async Task<StripeSubscription> CancelAsync(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null)
        {
            return await CancelAsync(subscriptionId, cancelAtPeriodEnd, requestOptions);
        }

        public virtual async Task<StripeSubscription> CancelAsync(string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.Subscriptions + "/{0}", subscriptionId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            return Mapper<StripeSubscription>.MapFromJson(
                await Requestor.DeleteAsync(url,
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeSubscription>> ListAsync(string customerId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format("/customers/{0}" + Urls.Subscriptions, customerId);

            return Mapper<StripeSubscription>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeSubscription>> ListAsync(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSubscription>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Subscriptions, true),
                SetupRequestOptions(requestOptions))
            );
        }
    }
}

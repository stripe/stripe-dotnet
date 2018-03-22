using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Stripe
{
    public partial class StripeSubscriptionService
    {
        //Sync
        [Obsolete("Get with customerId is deprecated, use Get without the customerId.")]
        public virtual StripeSubscription Get(string customerId, string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            return Get(subscriptionId, requestOptions);
        }

        [Obsolete("Update with customerId is deprecated, use Update without the customerId.")]
        public virtual StripeSubscription Update(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Update(subscriptionId, updateOptions, requestOptions);
        }

        [Obsolete("Cancel with customerId is deprecated, use Cancel without the customerId.")]
        public virtual StripeSubscription Cancel(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null)
        {
            return Cancel(subscriptionId, cancelAtPeriodEnd, requestOptions);
        }

        [Obsolete("List with customerId is deprecated, use List without the customerId.")]
        public virtual StripeList<StripeSubscription> List(string customerId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var options = new StripeSubscriptionListOptions
            {
                CustomerId = customerId
            };

            if (listOptions != null)
            {
                options.EndingBefore = listOptions.EndingBefore;
                options.StartingAfter = listOptions.StartingAfter;
                options.Limit = listOptions.Limit;
            }

            return List(options, requestOptions);
        }



        //Async
        [Obsolete("GetAsync with customerId is deprecated, use GetAsync without the customerId.")]
        public virtual Task<StripeSubscription> GetAsync(string customerId, string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetAsync(subscriptionId, requestOptions, cancellationToken);
        }

        [Obsolete("UpdateAsync with customerId is deprecated, use UpdateAsync without the customerId.")]
        public virtual Task<StripeSubscription> UpdateAsync(string customerId, string subscriptionId, StripeSubscriptionUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return UpdateAsync(subscriptionId, updateOptions, requestOptions, cancellationToken);
        }

        [Obsolete("CancelAsync with customerId is deprecated, use CancelAsync without the customerId.")]
        public virtual Task<StripeSubscription> CancelAsync(string customerId, string subscriptionId, bool cancelAtPeriodEnd = false, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return CancelAsync(subscriptionId, cancelAtPeriodEnd, requestOptions, cancellationToken);
        }

        [Obsolete("ListAsync with customerId is deprecated, use ListAsync without the customerId.")]
        public virtual Task<StripeList<StripeSubscription>> ListAsync(string customerId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new StripeSubscriptionListOptions
            {
                CustomerId = customerId
            };

            if (listOptions != null)
            {
                options.EndingBefore = listOptions.EndingBefore;
                options.StartingAfter = listOptions.StartingAfter;
                options.Limit = listOptions.Limit;
            }

            return ListAsync(options, requestOptions, cancellationToken);
        }
    }
}

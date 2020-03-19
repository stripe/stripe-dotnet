namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionService : Service<Subscription>,
        ICreatable<Subscription, SubscriptionCreateOptions>,
        IListable<Subscription, SubscriptionListOptions>,
        IRetrievable<Subscription, SubscriptionGetOptions>,
        IUpdatable<Subscription, SubscriptionUpdateOptions>
    {
        public SubscriptionService()
            : base(null)
        {
        }

        public SubscriptionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/subscriptions";

        public virtual Subscription Cancel(string subscriptionId, SubscriptionCancelOptions options, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(subscriptionId, options, requestOptions);
        }

        public virtual Task<Subscription> CancelAsync(string subscriptionId, SubscriptionCancelOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(subscriptionId, options, requestOptions, cancellationToken);
        }

        public virtual Subscription Create(SubscriptionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Subscription> CreateAsync(SubscriptionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Subscription Get(string subscriptionId, SubscriptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(subscriptionId, options, requestOptions);
        }

        public virtual Task<Subscription> GetAsync(string subscriptionId, SubscriptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(subscriptionId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Subscription> List(SubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Subscription>> ListAsync(SubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Subscription> ListAutoPaging(SubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Subscription> ListAutoPagingAsync(SubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Subscription Update(string subscriptionId, SubscriptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(subscriptionId, options, requestOptions);
        }

        public virtual Task<Subscription> UpdateAsync(string subscriptionId, SubscriptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(subscriptionId, options, requestOptions, cancellationToken);
        }
    }
}

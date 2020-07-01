namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionScheduleService : Service<SubscriptionSchedule>,
        ICreatable<SubscriptionSchedule, SubscriptionScheduleCreateOptions>,
        IListable<SubscriptionSchedule, SubscriptionScheduleListOptions>,
        IRetrievable<SubscriptionSchedule, SubscriptionScheduleGetOptions>,
        IUpdatable<SubscriptionSchedule, SubscriptionScheduleUpdateOptions>
    {
        public SubscriptionScheduleService()
            : base(null)
        {
        }

        public SubscriptionScheduleService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/subscription_schedules";

        public virtual SubscriptionSchedule Cancel(string id, SubscriptionScheduleCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> CancelAsync(string id, SubscriptionScheduleCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionSchedule Create(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> CreateAsync(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionSchedule Get(string id, SubscriptionScheduleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> GetAsync(string id, SubscriptionScheduleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SubscriptionSchedule> List(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<SubscriptionSchedule>> ListAsync(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SubscriptionSchedule> ListAutoPaging(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<SubscriptionSchedule> ListAutoPagingAsync(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual SubscriptionSchedule Release(string id, SubscriptionScheduleReleaseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/release", options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> ReleaseAsync(string id, SubscriptionScheduleReleaseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/release", options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionSchedule Update(string id, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> UpdateAsync(string id, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

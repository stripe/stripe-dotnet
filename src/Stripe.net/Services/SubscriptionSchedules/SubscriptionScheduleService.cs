namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionScheduleService : Service<SubscriptionSchedule>,
        ICreatable<SubscriptionSchedule, SubscriptionScheduleCreateOptions>,
        IListable<SubscriptionSchedule, SubscriptionScheduleListOptions>,
        IRetrievable<SubscriptionSchedule>,
        IUpdatable<SubscriptionSchedule, SubscriptionScheduleUpdateOptions>
    {
        public SubscriptionScheduleService()
            : base(null)
        {
        }

        public SubscriptionScheduleService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/subscription_schedules";

        public virtual SubscriptionSchedule Cancel(string scheduleId, SubscriptionScheduleCancelOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<SubscriptionSchedule>($"{this.InstanceUrl(scheduleId)}/cancel", options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> CancelAsync(string scheduleId, SubscriptionScheduleCancelOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<SubscriptionSchedule>($"{this.InstanceUrl(scheduleId)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionSchedule Create(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> CreateAsync(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionSchedule Get(string scheduleId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(scheduleId, null, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> GetAsync(string scheduleId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(scheduleId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<SubscriptionSchedule> List(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<SubscriptionSchedule>> ListAsync(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SubscriptionSchedule> ListAutoPaging(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual SubscriptionSchedule Release(string scheduleId, SubscriptionScheduleReleaseOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<SubscriptionSchedule>($"{this.InstanceUrl(scheduleId)}/release", options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> ReleaseAsync(string scheduleId, SubscriptionScheduleReleaseOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<SubscriptionSchedule>($"{this.InstanceUrl(scheduleId)}/release", options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionSchedule Update(string scheduleId, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(scheduleId, options, requestOptions);
        }

        public virtual Task<SubscriptionSchedule> UpdateAsync(string scheduleId, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(scheduleId, options, requestOptions, cancellationToken);
        }
    }
}

namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionScheduleRevisionService : ServiceNested<SubscriptionScheduleRevision>,
        INestedListable<SubscriptionScheduleRevision, SubscriptionScheduleRevisionListOptions>,
        INestedRetrievable<SubscriptionScheduleRevision, SubscriptionScheduleRevisionGetOptions>
    {
        public SubscriptionScheduleRevisionService()
            : base(null)
        {
        }

        public SubscriptionScheduleRevisionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/subscription_schedules/{PARENT_ID}/revisions";

        public virtual SubscriptionScheduleRevision Get(string scheduleId, string revisionId, SubscriptionScheduleRevisionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(scheduleId, revisionId, options, requestOptions);
        }

        public virtual Task<SubscriptionScheduleRevision> GetAsync(string scheduleId, string revisionId, SubscriptionScheduleRevisionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(scheduleId, revisionId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SubscriptionScheduleRevision> List(string scheduleId, SubscriptionScheduleRevisionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(scheduleId, options, requestOptions);
        }

        public virtual Task<StripeList<SubscriptionScheduleRevision>> ListAsync(string scheduleId, SubscriptionScheduleRevisionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(scheduleId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SubscriptionScheduleRevision> ListAutoPaging(string scheduleId, SubscriptionScheduleRevisionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(scheduleId, options, requestOptions);
        }
    }
}

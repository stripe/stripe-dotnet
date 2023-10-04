// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuotePreviewSubscriptionScheduleService : ServiceNested<QuotePreviewSubscriptionSchedule>,
        INestedListable<QuotePreviewSubscriptionSchedule, QuotePreviewSubscriptionScheduleListOptions>
    {
        public QuotePreviewSubscriptionScheduleService()
            : base(null)
        {
        }

        public QuotePreviewSubscriptionScheduleService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/quotes/{PARENT_ID}/preview_subscription_schedules";

        public virtual StripeList<QuotePreviewSubscriptionSchedule> List(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<QuotePreviewSubscriptionSchedule>> ListAsync(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<QuotePreviewSubscriptionSchedule> ListAutoPaging(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<QuotePreviewSubscriptionSchedule> ListAutoPagingAsync(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}

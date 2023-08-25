// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuotePreviewScheduleService : ServiceNested<QuotePreviewSchedule>,
        INestedListable<QuotePreviewSchedule, QuotePreviewScheduleListOptions>
    {
        public QuotePreviewScheduleService()
            : base(null)
        {
        }

        public QuotePreviewScheduleService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/quotes/{PARENT_ID}/preview_subscription_schedules";

        public virtual StripeList<QuotePreviewSchedule> List(string parentId, QuotePreviewScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<QuotePreviewSchedule>> ListAsync(string parentId, QuotePreviewScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<QuotePreviewSchedule> ListAutoPaging(string parentId, QuotePreviewScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<QuotePreviewSchedule> ListAutoPagingAsync(string parentId, QuotePreviewScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/quotes/{PARENT_ID}/preview_subscription_schedules";

        public virtual StripeList<QuotePreviewSubscriptionSchedule> List(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<QuotePreviewSubscriptionSchedule>>(HttpMethod.Get, $"/v1/quotes/{parentId}/preview_subscription_schedules", options, requestOptions);
        }

        public virtual Task<StripeList<QuotePreviewSubscriptionSchedule>> ListAsync(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<QuotePreviewSubscriptionSchedule>>(HttpMethod.Get, $"/v1/quotes/{parentId}/preview_subscription_schedules", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<QuotePreviewSubscriptionSchedule> ListAutoPaging(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<QuotePreviewSubscriptionSchedule>($"/v1/quotes/{parentId}/preview_subscription_schedules", options, requestOptions);
        }

        public virtual IAsyncEnumerable<QuotePreviewSubscriptionSchedule> ListAutoPagingAsync(string parentId, QuotePreviewSubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<QuotePreviewSubscriptionSchedule>($"/v1/quotes/{parentId}/preview_subscription_schedules", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class UsageRecordSummaryService : ServiceNested<UsageRecordSummary>,
        INestedListable<UsageRecordSummary, UsageRecordSummaryListOptions>
    {
        public UsageRecordSummaryService()
            : base(null)
        {
        }

        public UsageRecordSummaryService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/subscription_items/{PARENT_ID}/usage_record_summaries";

        public virtual StripeList<UsageRecordSummary> List(string parentId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<UsageRecordSummary>>(HttpMethod.Get, $"/v1/subscription_items/{parentId}/usage_record_summaries", options, requestOptions);
        }

        public virtual Task<StripeList<UsageRecordSummary>> ListAsync(string parentId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<UsageRecordSummary>>(HttpMethod.Get, $"/v1/subscription_items/{parentId}/usage_record_summaries", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<UsageRecordSummary> ListAutoPaging(string parentId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<UsageRecordSummary>($"/v1/subscription_items/{parentId}/usage_record_summaries", options, requestOptions);
        }

        public virtual IAsyncEnumerable<UsageRecordSummary> ListAutoPagingAsync(string parentId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<UsageRecordSummary>($"/v1/subscription_items/{parentId}/usage_record_summaries", options, requestOptions, cancellationToken);
        }
    }
}

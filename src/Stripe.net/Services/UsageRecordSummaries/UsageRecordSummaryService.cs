namespace Stripe
{
    using System.Collections.Generic;
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

        public virtual StripeList<UsageRecordSummary> List(string subscriptionItemId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(subscriptionItemId, options, requestOptions);
        }

        public virtual Task<StripeList<UsageRecordSummary>> ListAsync(string subscriptionItemId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(subscriptionItemId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<UsageRecordSummary> ListAutoPaging(string subscriptionItemId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(subscriptionItemId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<UsageRecordSummary> ListAutoPagingAsync(string subscriptionItemId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(subscriptionItemId, options, requestOptions, cancellationToken);
        }
#endif
    }
}

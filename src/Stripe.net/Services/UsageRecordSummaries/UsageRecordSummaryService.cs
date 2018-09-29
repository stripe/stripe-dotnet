namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class UsageRecordSummaryService : Service<UsageRecordSummary>,
        INestedListable<UsageRecordSummary, UsageRecordSummaryListOptions>
    {
        public UsageRecordSummaryService()
            : base(null)
        {
        }

        public UsageRecordSummaryService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeList<UsageRecordSummary> List(string subscriptionItemId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}/usage_record_summaries", requestOptions, options);
        }

        public virtual Task<StripeList<UsageRecordSummary>> ListAsync(string subscriptionItemId, UsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}/usage_record_summaries", requestOptions, cancellationToken, options);
        }
    }
}

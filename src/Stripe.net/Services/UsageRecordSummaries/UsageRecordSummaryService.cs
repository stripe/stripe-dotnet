namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class UsageRecordSummaryService : BasicService<StripeUsageRecord>
    {
        public UsageRecordSummaryService()
            : base(null)
        {
        }

        public UsageRecordSummaryService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeList<StripeUsageRecordSummary> List(string subscriptionItemId, UsageRecordSummaryListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            var url = $"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}/usage_record_summaries";
            return Mapper<StripeList<StripeUsageRecordSummary>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeList<StripeUsageRecordSummary>> ListAsync(string subscriptionItemId, UsageRecordSummaryListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = $"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}/usage_record_summaries";
            return Mapper<StripeList<StripeUsageRecordSummary>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

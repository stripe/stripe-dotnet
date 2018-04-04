using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeUsageRecordService : StripeBasicService<StripeUsageRecord>
    {
        public StripeUsageRecordService() : base(null) { }
        public StripeUsageRecordService(string apiKey) : base(apiKey) { }

        // Sync
        public virtual StripeUsageRecord Create(StripeUsageRecordCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/subscription_items/{options.SubscriptionItem}/usage_records", requestOptions, options);
        }


        // Async
        public virtual Task<StripeUsageRecord> CreateAsync(StripeUsageRecordCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/subscription_items/{options.SubscriptionItem}/usage_records", requestOptions, cancellationToken, options);
        }
    }
}

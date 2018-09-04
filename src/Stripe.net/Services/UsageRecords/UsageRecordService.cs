namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class UsageRecordService : BasicService<UsageRecord>,
        ICreatable<UsageRecord, UsageRecordCreateOptions>
    {
        public UsageRecordService()
            : base(null)
        {
        }

        public UsageRecordService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual UsageRecord Create(UsageRecordCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscription_items/{options.SubscriptionItem}/usage_records", requestOptions, options);
        }

        public virtual Task<UsageRecord> CreateAsync(UsageRecordCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscription_items/{options.SubscriptionItem}/usage_records", requestOptions, cancellationToken, options);
        }
    }
}

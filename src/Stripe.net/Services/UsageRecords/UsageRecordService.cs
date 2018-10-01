namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class UsageRecordService : ServiceNested<UsageRecord>,
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

        public override string BasePath => "/subscription_items/{PARENT_ID}/usage_records";

        public virtual UsageRecord Create(UsageRecordCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(options.SubscriptionItem, options, requestOptions);
        }

        public virtual Task<UsageRecord> CreateAsync(UsageRecordCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(options.SubscriptionItem, options, requestOptions, cancellationToken);
        }
    }
}

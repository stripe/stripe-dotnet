namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class UsageRecordService : ServiceNested<UsageRecord>,
        INestedCreatable<UsageRecord, UsageRecordCreateOptions>
    {
        public UsageRecordService()
            : base(null)
        {
        }

        public UsageRecordService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/subscription_items/{PARENT_ID}/usage_records";

        public virtual UsageRecord Create(string subscriptionItemId, UsageRecordCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(subscriptionItemId, options, requestOptions);
        }

        public virtual Task<UsageRecord> CreateAsync(string subscriptionItemId, UsageRecordCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(subscriptionItemId, options, requestOptions, cancellationToken);
        }
    }
}

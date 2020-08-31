namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public class UsageRecordService : ServiceNested<UsageRecord>,
        INestedCreatable<UsageRecord, UsageRecordCreateOptions>
    {
        public UsageRecordService()
            : base(null)
        {
        }

        public UsageRecordService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/subscription_items/{PARENT_ID}/usage_records";

        public virtual UsageRecord Create(string parentId, UsageRecordCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<UsageRecord> CreateAsync(string parentId, UsageRecordCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}

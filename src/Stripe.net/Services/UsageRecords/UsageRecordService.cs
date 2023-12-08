// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class UsageRecordService : ServiceNested<UsageRecord>
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

        public virtual UsageRecord Create(string parentId, UsageRecordCreateOptions options = null)
        {
            return this.Request<UsageRecord>(HttpMethod.Post, $"/v1/subscription_items/{parentId}/usage_records", options, null);
        }

        public virtual Task<UsageRecord> CreateAsync(string parentId, UsageRecordCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsageRecord>(HttpMethod.Post, $"/v1/subscription_items/{parentId}/usage_records", options, requestOptions, cancellationToken);
        }
    }
}

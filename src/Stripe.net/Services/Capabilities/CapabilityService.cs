namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CapabilityService : ServiceNested<Capability>,
        INestedListable<Capability, CapabilityListOptions>,
        INestedRetrievable<Capability, CapabilityGetOptions>,
        INestedUpdatable<Capability, CapabilityUpdateOptions>
    {
        public CapabilityService()
            : base(null)
        {
        }

        public CapabilityService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/capabilities";

        public virtual Capability Get(string accountId, string capabilityId, CapabilityGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(accountId, capabilityId, options, requestOptions);
        }

        public virtual Task<Capability> GetAsync(string accountId, string capabilityId, CapabilityGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(accountId, capabilityId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Capability> List(string accountId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(accountId, options, requestOptions);
        }

        public virtual Task<StripeList<Capability>> ListAsync(string accountId, CapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Capability> ListAutoPaging(string accountId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(accountId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Capability> ListAutoPagingAsync(string accountId, CapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(accountId, options, requestOptions, cancellationToken);
        }
#endif

        public virtual Capability Update(string accountId,  string capabilityId, CapabilityUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(accountId, capabilityId, options, requestOptions);
        }

        public virtual Task<Capability> UpdateAsync(string accountId,  string capabilityId, CapabilityUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(accountId, capabilityId, options, requestOptions, cancellationToken);
        }
    }
}

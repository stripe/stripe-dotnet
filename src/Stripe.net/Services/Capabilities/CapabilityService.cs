// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/accounts/{PARENT_ID}/capabilities";

        public virtual Capability Get(string parentId, string id, CapabilityGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Capability>(HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions);
        }

        public virtual Task<Capability> GetAsync(string parentId, string id, CapabilityGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Capability>(HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Capability> List(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Capability>>(HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities", options, requestOptions);
        }

        public virtual Task<StripeList<Capability>> ListAsync(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Capability>>(HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Capability> ListAutoPaging(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Capability>($"/v1/accounts/{parentId}/capabilities", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Capability> ListAutoPagingAsync(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Capability>($"/v1/accounts/{parentId}/capabilities", options, requestOptions, cancellationToken);
        }

        public virtual Capability Update(string parentId, string id, CapabilityUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Capability>(HttpMethod.Post, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions);
        }

        public virtual Task<Capability> UpdateAsync(string parentId, string id, CapabilityUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Capability>(HttpMethod.Post, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions, cancellationToken);
        }
    }
}

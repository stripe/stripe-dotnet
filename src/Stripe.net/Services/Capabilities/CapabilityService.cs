namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    [Obsolete("Use AccountCapabilityService instead.")]
    public class CapabilityService : ServiceNested<Capability>,
        INestedListable<Capability, CapabilityListOptions>,
        INestedRetrievable<Capability, CapabilityGetOptions>,
        INestedUpdatable<Capability, CapabilityUpdateOptions>
    {
        public CapabilityService()
        {
        }

        internal CapabilityService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CapabilityService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves information about the specified Account Capability.</p>.
        /// </summary>
        public virtual Capability Get(string parentId, string id, CapabilityGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Capability>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves information about the specified Account Capability.</p>.
        /// </summary>
        public virtual Task<Capability> GetAsync(string parentId, string id, CapabilityGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Capability>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of capabilities associated with the account. The capabilities are
        /// returned sorted by creation date, with the most recent capability appearing first.</p>.
        /// </summary>
        public virtual StripeList<Capability> List(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Capability>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of capabilities associated with the account. The capabilities are
        /// returned sorted by creation date, with the most recent capability appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Capability>> ListAsync(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Capability>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/capabilities", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of capabilities associated with the account. The capabilities are
        /// returned sorted by creation date, with the most recent capability appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Capability> ListAutoPaging(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Capability>($"/v1/accounts/{parentId}/capabilities", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of capabilities associated with the account. The capabilities are
        /// returned sorted by creation date, with the most recent capability appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Capability> ListAutoPagingAsync(string parentId, CapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Capability>($"/v1/accounts/{parentId}/capabilities", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing Account Capability. Request or remove a capability by updating
        /// its <c>requested</c> parameter.</p>.
        /// </summary>
        public virtual Capability Update(string parentId, string id, CapabilityUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Capability>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing Account Capability. Request or remove a capability by updating
        /// its <c>requested</c> parameter.</p>.
        /// </summary>
        public virtual Task<Capability> UpdateAsync(string parentId, string id, CapabilityUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Capability>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/capabilities/{id}", options, requestOptions, cancellationToken);
        }
    }
}

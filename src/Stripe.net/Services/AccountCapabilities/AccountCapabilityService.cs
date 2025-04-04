// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountCapabilityService : Service,
        INestedRetrievable<Capability, AccountCapabilityGetOptions>,
        INestedUpdatable<Capability, AccountCapabilityUpdateOptions>
    {
        public AccountCapabilityService()
        {
        }

        internal AccountCapabilityService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountCapabilityService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves information about the specified Account Capability.</p>.
        /// </summary>
        public virtual Capability Get(string parentId, string id, AccountCapabilityGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Capability>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves information about the specified Account Capability.</p>.
        /// </summary>
        public virtual Task<Capability> GetAsync(string parentId, string id, AccountCapabilityGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Capability>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of capabilities associated with the account. The capabilities are
        /// returned sorted by creation date, with the most recent capability appearing first.</p>.
        /// </summary>
        public virtual StripeList<Capability> List(string parentId, AccountCapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Capability>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/capabilities", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of capabilities associated with the account. The capabilities are
        /// returned sorted by creation date, with the most recent capability appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Capability>> ListAsync(string parentId, AccountCapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Capability>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/capabilities", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing Account Capability. Request or remove a capability by updating
        /// its <c>requested</c> parameter.</p>.
        /// </summary>
        public virtual Capability Update(string parentId, string id, AccountCapabilityUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Capability>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing Account Capability. Request or remove a capability by updating
        /// its <c>requested</c> parameter.</p>.
        /// </summary>
        public virtual Task<Capability> UpdateAsync(string parentId, string id, AccountCapabilityUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Capability>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

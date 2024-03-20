// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerEntitlementService : ServiceNested<CustomerEntitlement>,
        INestedListable<CustomerEntitlement, CustomerEntitlementListOptions>
    {
        public CustomerEntitlementService()
        {
        }

        public CustomerEntitlementService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve a list of entitlements for a customer</p>.
        /// </summary>
        public virtual StripeList<CustomerEntitlement> List(string parentId, CustomerEntitlementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CustomerEntitlement>>(HttpMethod.Get, $"/v1/customers/{parentId}/entitlements", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of entitlements for a customer</p>.
        /// </summary>
        public virtual Task<StripeList<CustomerEntitlement>> ListAsync(string parentId, CustomerEntitlementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CustomerEntitlement>>(HttpMethod.Get, $"/v1/customers/{parentId}/entitlements", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of entitlements for a customer</p>.
        /// </summary>
        public virtual IEnumerable<CustomerEntitlement> ListAutoPaging(string parentId, CustomerEntitlementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomerEntitlement>($"/v1/customers/{parentId}/entitlements", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of entitlements for a customer</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CustomerEntitlement> ListAutoPagingAsync(string parentId, CustomerEntitlementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomerEntitlement>($"/v1/customers/{parentId}/entitlements", options, requestOptions, cancellationToken);
        }
    }
}

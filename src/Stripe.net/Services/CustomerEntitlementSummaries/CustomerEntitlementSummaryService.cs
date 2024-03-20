// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerEntitlementSummaryService : ServiceNested<CustomerEntitlementSummary>
    {
        public CustomerEntitlementSummaryService()
        {
        }

        public CustomerEntitlementSummaryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve the entitlement summary for a customer</p>.
        /// </summary>
        public virtual CustomerEntitlementSummary Get(string parentId, CustomerEntitlementSummaryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerEntitlementSummary>(HttpMethod.Get, $"/v1/customers/{parentId}/entitlement_summary", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve the entitlement summary for a customer</p>.
        /// </summary>
        public virtual Task<CustomerEntitlementSummary> GetAsync(string parentId, CustomerEntitlementSummaryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerEntitlementSummary>(HttpMethod.Get, $"/v1/customers/{parentId}/entitlement_summary", options, requestOptions, cancellationToken);
        }
    }
}

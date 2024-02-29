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
            : base(null)
        {
        }

        public CustomerEntitlementSummaryService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/customers/{PARENT_ID}/entitlement_summary";

        public virtual CustomerEntitlementSummary Get(string parentId, CustomerEntitlementSummaryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerEntitlementSummary>(HttpMethod.Get, $"/v1/customers/{parentId}/entitlement_summary", options, requestOptions);
        }

        public virtual Task<CustomerEntitlementSummary> GetAsync(string parentId, CustomerEntitlementSummaryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerEntitlementSummary>(HttpMethod.Get, $"/v1/customers/{parentId}/entitlement_summary", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditBalanceSummaryService : Service<CreditBalanceSummary>,
        ISingletonRetrievable<CreditBalanceSummary>
    {
        public CreditBalanceSummaryService()
        {
        }

        public CreditBalanceSummaryService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/credit_balance_summary";

        [Obsolete("This member is deprecated and will be removed in a future release")]
        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer</p>.
        /// </summary>
        public virtual CreditBalanceSummary Get(RequestOptions requestOptions = null)
        {
            return this.Request<CreditBalanceSummary>(HttpMethod.Get, $"/v1/billing/credit_balance_summary", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer</p>.
        /// </summary>
        public virtual Task<CreditBalanceSummary> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditBalanceSummary>(HttpMethod.Get, $"/v1/billing/credit_balance_summary", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer</p>.
        /// </summary>
        public virtual CreditBalanceSummary Get(CreditBalanceSummaryGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditBalanceSummary>(HttpMethod.Get, $"/v1/billing/credit_balance_summary", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer</p>.
        /// </summary>
        public virtual Task<CreditBalanceSummary> GetAsync(CreditBalanceSummaryGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditBalanceSummary>(HttpMethod.Get, $"/v1/billing/credit_balance_summary", options, requestOptions, cancellationToken);
        }
    }
}

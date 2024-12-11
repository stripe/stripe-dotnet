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

        internal CreditBalanceSummaryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CreditBalanceSummaryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer.</p>.
        /// </summary>
        public virtual CreditBalanceSummary Get(RequestOptions requestOptions = null)
        {
            return this.Request<CreditBalanceSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/credit_balance_summary", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer.</p>.
        /// </summary>
        public virtual Task<CreditBalanceSummary> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditBalanceSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/credit_balance_summary", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer.</p>.
        /// </summary>
        public virtual CreditBalanceSummary Get(CreditBalanceSummaryGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditBalanceSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/credit_balance_summary", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the credit balance summary for a customer.</p>.
        /// </summary>
        public virtual Task<CreditBalanceSummary> GetAsync(CreditBalanceSummaryGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditBalanceSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/credit_balance_summary", options, requestOptions, cancellationToken);
        }
    }
}

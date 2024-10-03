// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancingSummaryService : Service<FinancingSummary>,
        ISingletonRetrievable<FinancingSummary>
    {
        public FinancingSummaryService()
        {
        }

        internal FinancingSummaryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FinancingSummaryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve the financing state for the account that was authenticated in the
        /// request.</p>.
        /// </summary>
        public virtual FinancingSummary Get(RequestOptions requestOptions = null)
        {
            return this.Request<FinancingSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_summary", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve the financing state for the account that was authenticated in the
        /// request.</p>.
        /// </summary>
        public virtual Task<FinancingSummary> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancingSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_summary", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve the financing state for the account that was authenticated in the
        /// request.</p>.
        /// </summary>
        public virtual FinancingSummary Get(FinancingSummaryGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancingSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_summary", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve the financing state for the account that was authenticated in the
        /// request.</p>.
        /// </summary>
        public virtual Task<FinancingSummary> GetAsync(FinancingSummaryGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancingSummary>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_summary", options, requestOptions, cancellationToken);
        }
    }
}

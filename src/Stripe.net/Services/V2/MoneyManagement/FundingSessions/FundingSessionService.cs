// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FundingSessionService : Service
    {
        internal FundingSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FundingSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a FundingSession: a hosted funding surface for a customer to fund a
        /// FinancialAccount.
        /// </summary>
        public virtual FundingSession Create(FundingSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FundingSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_sessions", options, requestOptions);
        }

        /// <summary>
        /// Create a FundingSession: a hosted funding surface for a customer to fund a
        /// FinancialAccount.
        /// </summary>
        public virtual Task<FundingSession> CreateAsync(FundingSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_sessions", options, requestOptions, cancellationToken);
        }
    }
}

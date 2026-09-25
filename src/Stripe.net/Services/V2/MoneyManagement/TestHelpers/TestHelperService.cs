// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TestHelperService : Service
    {
        private V2.MoneyManagement.TestHelpers.FinancialAddressService financialAddresses;

        internal TestHelperService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TestHelperService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.MoneyManagement.TestHelpers.FinancialAddressService FinancialAddresses => this.financialAddresses ??= new V2.MoneyManagement.TestHelpers.FinancialAddressService(
            this.Requestor);

        /// <summary>
        /// Creates an EarnedCredit in a Sandbox environment for testing purposes.
        /// </summary>
        public virtual EarnedCreditSimulation EarnedCredits(TestHelperEarnedCreditsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<EarnedCreditSimulation>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/test_helpers/earned_credits", options, requestOptions);
        }

        /// <summary>
        /// Creates an EarnedCredit in a Sandbox environment for testing purposes.
        /// </summary>
        public virtual Task<EarnedCreditSimulation> EarnedCreditsAsync(TestHelperEarnedCreditsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<EarnedCreditSimulation>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/test_helpers/earned_credits", options, requestOptions, cancellationToken);
        }
    }
}

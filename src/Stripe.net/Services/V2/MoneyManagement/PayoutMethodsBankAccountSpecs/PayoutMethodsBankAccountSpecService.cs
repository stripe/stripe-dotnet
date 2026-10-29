// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PayoutMethodsBankAccountSpecService : Service
    {
        internal PayoutMethodsBankAccountSpecService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PayoutMethodsBankAccountSpecService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Fetch the specifications for a set of countries to know which credential fields are
        /// required, the validations for each fields, and how to translate these country-specific
        /// fields to the generic fields in the PayoutMethodBankAccount type.
        /// </summary>
        public virtual PayoutMethodsBankAccountSpec Get(PayoutMethodsBankAccountSpecGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutMethodsBankAccountSpec>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_methods_bank_account_spec", options, requestOptions);
        }

        /// <summary>
        /// Fetch the specifications for a set of countries to know which credential fields are
        /// required, the validations for each fields, and how to translate these country-specific
        /// fields to the generic fields in the PayoutMethodBankAccount type.
        /// </summary>
        public virtual Task<PayoutMethodsBankAccountSpec> GetAsync(PayoutMethodsBankAccountSpecGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutMethodsBankAccountSpec>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_methods_bank_account_spec", options, requestOptions, cancellationToken);
        }
    }
}

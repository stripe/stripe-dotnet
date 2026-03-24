// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountPayments : StripeEntity<FinancialAccountPayments>
    {
        /// <summary>
        /// The balance of the <c>payments</c> FinancialAccount is a mix of payment processing and
        /// stored value funds, and this field describes the breakdown between the two. The sum will
        /// match the balance of the FinancialAccount.
        /// </summary>
        [JsonProperty("balance_by_funds_type")]
        [STJS.JsonPropertyName("balance_by_funds_type")]
        public FinancialAccountPaymentsBalanceByFundsType BalanceByFundsType { get; set; }

        /// <summary>
        /// The currency that non-settlement currency payments will be converted to.
        /// </summary>
        [JsonProperty("default_currency")]
        [STJS.JsonPropertyName("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Settlement currencies enabled for this FinancialAccount. Payments in other currencies
        /// will be automatically converted to <c>default_currency</c>.
        /// </summary>
        [JsonProperty("settlement_currencies")]
        [STJS.JsonPropertyName("settlement_currencies")]
        public List<string> SettlementCurrencies { get; set; }

        /// <summary>
        /// Describes the available balance when it was projected.
        /// </summary>
        [JsonProperty("starting_balance")]
        [STJS.JsonPropertyName("starting_balance")]
        public FinancialAccountPaymentsStartingBalance StartingBalance { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountPayments : StripeEntity<FinancialAccountPayments>
    {
        /// <summary>
        /// The currency that non-settlement currency payments will be converted to.
        /// </summary>
        [JsonProperty("default_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_currency")]
#endif
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Settlement currencies enabled for this FinancialAccount. Payments in other currencies
        /// will be automatically converted to <c>default_currency</c>.
        /// </summary>
        [JsonProperty("settlement_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement_currencies")]
#endif
        public List<string> SettlementCurrencies { get; set; }

        /// <summary>
        /// Describes the available balance when it was projected.
        /// </summary>
        [JsonProperty("starting_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starting_balance")]
#endif
        public FinancialAccountPaymentsStartingBalance StartingBalance { get; set; }
    }
}

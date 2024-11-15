// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceSummaryBalance : StripeEntity<CreditBalanceSummaryBalance>
    {
        [JsonProperty("available_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available_balance")]
#endif

        public CreditBalanceSummaryBalanceAvailableBalance AvailableBalance { get; set; }

        [JsonProperty("ledger_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ledger_balance")]
#endif

        public CreditBalanceSummaryBalanceLedgerBalance LedgerBalance { get; set; }
    }
}

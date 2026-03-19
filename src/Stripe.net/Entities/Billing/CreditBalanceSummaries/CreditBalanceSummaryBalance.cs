// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditBalanceSummaryBalance : StripeEntity<CreditBalanceSummaryBalance>
    {
        [JsonProperty("available_balance")]
        [STJS.JsonPropertyName("available_balance")]
        public CreditBalanceSummaryBalanceAvailableBalance AvailableBalance { get; set; }

        [JsonProperty("ledger_balance")]
        [STJS.JsonPropertyName("ledger_balance")]
        public CreditBalanceSummaryBalanceLedgerBalance LedgerBalance { get; set; }
    }
}

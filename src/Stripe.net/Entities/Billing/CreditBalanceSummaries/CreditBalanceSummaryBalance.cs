// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceSummaryBalance : StripeEntity<CreditBalanceSummaryBalance>
    {
        [JsonProperty("available_balance")]
        public CreditBalanceSummaryBalanceAvailableBalance AvailableBalance { get; set; }

        [JsonProperty("ledger_balance")]
        public CreditBalanceSummaryBalanceLedgerBalance LedgerBalance { get; set; }
    }
}

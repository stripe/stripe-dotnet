// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceSummaryBalanceLedgerBalance : StripeEntity<CreditBalanceSummaryBalanceLedgerBalance>
    {
        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
        public CreditBalanceSummaryBalanceLedgerBalanceMonetary Monetary { get; set; }

        /// <summary>
        /// The type of this amount. We currently only support <c>monetary</c> credits.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

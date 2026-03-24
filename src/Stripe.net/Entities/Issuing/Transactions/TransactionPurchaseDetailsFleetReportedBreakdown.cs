// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionPurchaseDetailsFleetReportedBreakdown : StripeEntity<TransactionPurchaseDetailsFleetReportedBreakdown>
    {
        /// <summary>
        /// Breakdown of fuel portion of the purchase.
        /// </summary>
        [JsonProperty("fuel")]
        [STJS.JsonPropertyName("fuel")]
        public TransactionPurchaseDetailsFleetReportedBreakdownFuel Fuel { get; set; }

        /// <summary>
        /// Breakdown of non-fuel portion of the purchase.
        /// </summary>
        [JsonProperty("non_fuel")]
        [STJS.JsonPropertyName("non_fuel")]
        public TransactionPurchaseDetailsFleetReportedBreakdownNonFuel NonFuel { get; set; }

        /// <summary>
        /// Information about tax included in this transaction.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public TransactionPurchaseDetailsFleetReportedBreakdownTax Tax { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalsDelinquencyIndicator : StripeEntity<AccountSignalsDelinquencyIndicator>
    {
        /// <summary>
        /// A brief explanation of how this indicator contributed to the delinquency probability.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The effect this indicator had on the overall risk level.
        /// One of: <c>decrease</c>, <c>neutral</c>, <c>slight_increase</c>, or
        /// <c>strong_increase</c>.
        /// </summary>
        [JsonProperty("impact")]
        [STJS.JsonPropertyName("impact")]
        public string Impact { get; set; }

        /// <summary>
        /// The name of the specific indicator used in the risk assessment.
        /// One of: <c>account_balance</c>, <c>aov</c>, <c>charge_concentration</c>,
        /// <c>dispute_window</c>, <c>disputes</c>, <c>duplicates</c>, <c>exposure</c>,
        /// <c>firmographic</c>, <c>lifetime_metrics</c>, <c>payment_processing</c>,
        /// <c>payment_volume</c>, <c>payouts</c>, <c>refunds</c>, <c>related_accounts</c>,
        /// <c>tenure</c>, or <c>transfers</c>.
        /// </summary>
        [JsonProperty("indicator")]
        [STJS.JsonPropertyName("indicator")]
        public string Indicator { get; set; }
    }
}

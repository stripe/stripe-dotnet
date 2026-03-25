// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalsFraudIntentIndicator : StripeEntity<AccountSignalsFraudIntentIndicator>
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
        /// One of: <c>bank_account</c>, <c>business_information_and_account_activity</c>,
        /// <c>disputes</c>, <c>failures</c>, <c>geo_location</c>, <c>other</c>,
        /// <c>other_related_accounts</c>, <c>other_transaction_activity</c>, <c>owner_email</c>, or
        /// <c>web_presence</c>.
        /// </summary>
        [JsonProperty("indicator")]
        [STJS.JsonPropertyName("indicator")]
        public string Indicator { get; set; }
    }
}

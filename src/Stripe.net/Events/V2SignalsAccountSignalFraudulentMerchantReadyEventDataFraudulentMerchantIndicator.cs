// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2SignalsAccountSignalFraudulentMerchantReadyEventDataFraudulentMerchantIndicator : StripeEntity<V2SignalsAccountSignalFraudulentMerchantReadyEventDataFraudulentMerchantIndicator>
    {
        /// <summary>
        /// A brief explanation of how this indicator contributed to the fraudulent merchant
        /// probability.
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
        /// <c>disputes</c>, <c>failures</c>, <c>geolocation</c>, <c>other</c>,
        /// <c>other_related_accounts</c>, <c>other_transaction_activity</c>, <c>owner_email</c>, or
        /// <c>web_presence</c>.
        /// </summary>
        [JsonProperty("indicator")]
        [STJS.JsonPropertyName("indicator")]
        public string Indicator { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalFraudulentWebsite : StripeEntity<AccountSignalFraudulentWebsite>
    {
        /// <summary>
        /// Additional information about the fraudulent website evaluation, when available.
        /// </summary>
        [JsonProperty("additional_details")]
        [STJS.JsonPropertyName("additional_details")]
        public AccountSignalFraudulentWebsiteAdditionalDetails AdditionalDetails { get; set; }

        /// <summary>
        /// Categorical assessment of the fraudulent website risk.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }
    }
}

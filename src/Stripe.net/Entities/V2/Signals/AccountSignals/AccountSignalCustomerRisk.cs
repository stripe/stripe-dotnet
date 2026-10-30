// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalCustomerRisk : StripeEntity<AccountSignalCustomerRisk>
    {
        /// <summary>
        /// Supplementary contextual data for the signal, including indicators. Absent when no
        /// indicators are available.
        /// </summary>
        [JsonProperty("additional_details")]
        [STJS.JsonPropertyName("additional_details")]
        public AccountSignalCustomerRiskAdditionalDetails AdditionalDetails { get; set; }

        /// <summary>
        /// Categorical assessment of the customer's risk of fraudulent or abusive activity.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationRegistrationInitiatedOptions : INestedOptions
    {
        /// <summary>
        /// Client device metadata details (e.g., radar_session).
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
        [STJS.JsonPropertyName("client_device_metadata_details")]
        public AccountEvaluationRegistrationInitiatedClientDeviceMetadataDetailsOptions ClientDeviceMetadataDetails { get; set; }

        /// <summary>
        /// Stripe customer ID.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Customer data.
        /// </summary>
        [JsonProperty("customer_data")]
        [STJS.JsonPropertyName("customer_data")]
        public AccountEvaluationRegistrationInitiatedCustomerDataOptions CustomerData { get; set; }
    }
}

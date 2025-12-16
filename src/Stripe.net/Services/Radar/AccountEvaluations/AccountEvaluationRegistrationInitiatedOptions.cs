// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountEvaluationRegistrationInitiatedOptions : INestedOptions
    {
        /// <summary>
        /// Client device metadata details (e.g., radar_session).
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_device_metadata_details")]
#endif
        public AccountEvaluationRegistrationInitiatedClientDeviceMetadataDetailsOptions ClientDeviceMetadataDetails { get; set; }

        /// <summary>
        /// Stripe customer ID.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Customer data.
        /// </summary>
        [JsonProperty("customer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_data")]
#endif
        public AccountEvaluationRegistrationInitiatedCustomerDataOptions CustomerData { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLocationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The full address of the location.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Identification numbers associated with the location.
        /// </summary>
        [JsonProperty("business_registration")]
        [STJS.JsonPropertyName("business_registration")]
        public PaymentLocationBusinessRegistrationOptions BusinessRegistration { get; set; }

        /// <summary>
        /// A name for the location.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Pass true when updating location fields that will trigger onboarding review for any of
        /// the location's active location capabilities. If this parameter is not set to true,
        /// updates that would trigger onboarding review will fail. Only applicable for locations
        /// with active location capabilities.
        /// </summary>
        [JsonProperty("onboarding_data_update_acknowledged")]
        [STJS.JsonPropertyName("onboarding_data_update_acknowledged")]
        public bool? OnboardingDataUpdateAcknowledged { get; set; }
    }
}

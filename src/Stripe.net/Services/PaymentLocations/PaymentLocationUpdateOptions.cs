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
    }
}

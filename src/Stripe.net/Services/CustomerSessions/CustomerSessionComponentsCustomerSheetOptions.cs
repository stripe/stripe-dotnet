// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerSessionComponentsCustomerSheetOptions : INestedOptions
    {
        /// <summary>
        /// Whether the customer sheet is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This hash defines whether the customer sheet supports certain features.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public CustomerSessionComponentsCustomerSheetFeaturesOptions Features { get; set; }
    }
}

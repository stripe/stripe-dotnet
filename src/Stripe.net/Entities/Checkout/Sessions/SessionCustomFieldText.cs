// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCustomFieldText : StripeEntity<SessionCustomFieldText>
    {
        /// <summary>
        /// The value that pre-fills the field on the payment page.
        /// </summary>
        [JsonProperty("default_value")]
        [STJS.JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The maximum character length constraint for the customer's input.
        /// </summary>
        [JsonProperty("maximum_length")]
        [STJS.JsonPropertyName("maximum_length")]
        public long? MaximumLength { get; set; }

        /// <summary>
        /// The minimum character length requirement for the customer's input.
        /// </summary>
        [JsonProperty("minimum_length")]
        [STJS.JsonPropertyName("minimum_length")]
        public long? MinimumLength { get; set; }

        /// <summary>
        /// The value entered by the customer.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}

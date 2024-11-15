// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCustomFieldNumeric : StripeEntity<SessionCustomFieldNumeric>
    {
        /// <summary>
        /// The value that will pre-fill the field on the payment page.
        /// </summary>
        [JsonProperty("default_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_value")]
#endif

        public string DefaultValue { get; set; }

        /// <summary>
        /// The maximum character length constraint for the customer's input.
        /// </summary>
        [JsonProperty("maximum_length")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_length")]
#endif

        public long? MaximumLength { get; set; }

        /// <summary>
        /// The minimum character length requirement for the customer's input.
        /// </summary>
        [JsonProperty("minimum_length")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_length")]
#endif

        public long? MinimumLength { get; set; }

        /// <summary>
        /// The value entered by the customer, containing only digits.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif

        public string Value { get; set; }
    }
}

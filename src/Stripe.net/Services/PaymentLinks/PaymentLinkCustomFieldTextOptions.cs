// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkCustomFieldTextOptions : INestedOptions
    {
        /// <summary>
        /// The value that pre-fills the field on the payment page.
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
    }
}

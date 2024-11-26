// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardShippingAddressValidation : StripeEntity<CardShippingAddressValidation>
    {
        /// <summary>
        /// The address validation capabilities to use.
        /// One of: <c>disabled</c>, <c>normalization_only</c>, or
        /// <c>validation_and_normalization</c>.
        /// </summary>
        [JsonProperty("mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mode")]
#endif
        public string Mode { get; set; }

        /// <summary>
        /// The normalized shipping address.
        /// </summary>
        [JsonProperty("normalized_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("normalized_address")]
#endif
        public Address NormalizedAddress { get; set; }

        /// <summary>
        /// The validation result for the shipping address.
        /// One of: <c>indeterminate</c>, <c>likely_deliverable</c>, or <c>likely_undeliverable</c>.
        /// </summary>
        [JsonProperty("result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result")]
#endif
        public string Result { get; set; }
    }
}

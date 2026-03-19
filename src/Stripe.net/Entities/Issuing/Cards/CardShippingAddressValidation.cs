// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardShippingAddressValidation : StripeEntity<CardShippingAddressValidation>
    {
        /// <summary>
        /// The address validation capabilities to use.
        /// One of: <c>disabled</c>, <c>normalization_only</c>, or
        /// <c>validation_and_normalization</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The normalized shipping address.
        /// </summary>
        [JsonProperty("normalized_address")]
        [STJS.JsonPropertyName("normalized_address")]
        public Address NormalizedAddress { get; set; }

        /// <summary>
        /// The validation result for the shipping address.
        /// One of: <c>indeterminate</c>, <c>likely_deliverable</c>, or <c>likely_undeliverable</c>.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public string Result { get; set; }
    }
}

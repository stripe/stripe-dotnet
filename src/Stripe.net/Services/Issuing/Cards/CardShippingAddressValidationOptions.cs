// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardShippingAddressValidationOptions : INestedOptions
    {
        /// <summary>
        /// The address validation capabilities to use.
        /// One of: <c>disabled</c>, <c>normalization_only</c>, or
        /// <c>validation_and_normalization</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}

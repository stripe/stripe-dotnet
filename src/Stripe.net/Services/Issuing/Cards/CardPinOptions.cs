// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardPinOptions : INestedOptions
    {
        /// <summary>
        /// The card's desired new PIN, encrypted under Stripe's public key.
        /// </summary>
        [JsonProperty("encrypted_number")]
        [STJS.JsonPropertyName("encrypted_number")]
        public string EncryptedNumber { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardPinOptions : INestedOptions
    {
        /// <summary>
        /// The card's desired new PIN, encrypted under Stripe's public key.
        /// </summary>
        [JsonProperty("encrypted_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("encrypted_number")]
#endif
        public string EncryptedNumber { get; set; }
    }
}

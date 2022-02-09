// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardPinOptions : INestedOptions
    {
        /// <summary>
        /// The card's desired new PIN, encrypted under Stripe's public key.
        /// </summary>
        [JsonProperty("encrypted_number")]
        public string EncryptedNumber { get; set; }
    }
}

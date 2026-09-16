// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class NetworkTokenCreateCardOptions : INestedOptions
    {
        /// <summary>
        /// The two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public string ExpMonth { get; set; }

        /// <summary>
        /// The four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public string ExpYear { get; set; }

        /// <summary>
        /// The card number.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// The optional origin attestation for the card.
        /// </summary>
        [JsonProperty("origin")]
        [STJS.JsonPropertyName("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Optional owner contact details used only when a network requires them for raw-card
        /// tokenization.
        /// </summary>
        [JsonProperty("owner_details")]
        [STJS.JsonPropertyName("owner_details")]
        public NetworkTokenCreateCardOwnerDetailsOptions OwnerDetails { get; set; }
    }
}

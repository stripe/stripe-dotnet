// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TokenNetworkDataWalletProviderCardholderAddress : StripeEntity<TokenNetworkDataWalletProviderCardholderAddress>
    {
        /// <summary>
        /// The street address of the cardholder tokenizing the card.
        /// </summary>
        [JsonProperty("line1")]
        [STJS.JsonPropertyName("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// The postal code of the cardholder tokenizing the card.
        /// </summary>
        [JsonProperty("postal_code")]
        [STJS.JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }
    }
}

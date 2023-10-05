// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TokenNetworkDataWalletProviderCardholderAddress : StripeEntity<TokenNetworkDataWalletProviderCardholderAddress>
    {
        /// <summary>
        /// The street address of the cardholder tokenizing the card.
        /// </summary>
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// The postal code of the cardholder tokenizing the card.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }
}

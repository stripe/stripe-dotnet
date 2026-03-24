// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityAttestationsTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Account's acceptance of the [Stripe Services Agreement]; IP, date, and
        /// User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceAccountOptions Account { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Issuing-specific terms of service.
        /// </summary>
        [JsonProperty("card_creator")]
        [STJS.JsonPropertyName("card_creator")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorOptions CardCreator { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Crypto-storer-specific terms of service; IP,
        /// date, and User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("crypto_storer")]
        [STJS.JsonPropertyName("crypto_storer")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCryptoStorerOptions CryptoStorer { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Treasury-specific terms of service; IP, date, and
        /// User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("storer")]
        [STJS.JsonPropertyName("storer")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceStorerOptions Storer { get; set; }
    }
}

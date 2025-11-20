// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityAttestationsTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Account's acceptance of the [Stripe Services Agreement]; IP, date, and
        /// User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public AccountTokenCreateIdentityAttestationsTermsOfServiceAccountOptions Account { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Issuing-specific terms of service.
        /// </summary>
        [JsonProperty("card_creator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_creator")]
#endif
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorOptions CardCreator { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Crypto-storer-specific terms of service; IP,
        /// date, and User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("crypto_storer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_storer")]
#endif
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCryptoStorerOptions CryptoStorer { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Treasury-specific terms of service; IP, date, and
        /// User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("storer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("storer")]
#endif
        public AccountTokenCreateIdentityAttestationsTermsOfServiceStorerOptions Storer { get; set; }
    }
}

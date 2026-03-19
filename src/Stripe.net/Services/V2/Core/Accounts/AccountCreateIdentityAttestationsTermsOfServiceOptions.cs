// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Account's acceptance of the <a
        /// href="https://docs.stripe.com/connect/updating-accounts#tos-acceptance">Stripe Services
        /// Agreement</a>.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public AccountCreateIdentityAttestationsTermsOfServiceAccountOptions Account { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Issuing-specific terms of service.
        /// </summary>
        [JsonProperty("card_creator")]
        [STJS.JsonPropertyName("card_creator")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorOptions CardCreator { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Crypto-storer-specific terms of service.
        /// </summary>
        [JsonProperty("crypto_storer")]
        [STJS.JsonPropertyName("crypto_storer")]
        public AccountCreateIdentityAttestationsTermsOfServiceCryptoStorerOptions CryptoStorer { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Treasury-specific terms of service.
        /// </summary>
        [JsonProperty("storer")]
        [STJS.JsonPropertyName("storer")]
        public AccountCreateIdentityAttestationsTermsOfServiceStorerOptions Storer { get; set; }
    }
}

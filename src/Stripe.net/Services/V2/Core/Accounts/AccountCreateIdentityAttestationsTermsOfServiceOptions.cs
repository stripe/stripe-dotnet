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
        /// Details on the Account's acceptance of Consumer-specific terms of service.
        /// </summary>
        [JsonProperty("consumer_money_manager")]
        [STJS.JsonPropertyName("consumer_money_manager")]
        public AccountCreateIdentityAttestationsTermsOfServiceConsumerMoneyManagerOptions ConsumerMoneyManager { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Consumer-privacy-disclosures-specific terms of
        /// service.
        /// </summary>
        [JsonProperty("consumer_privacy_disclosures")]
        [STJS.JsonPropertyName("consumer_privacy_disclosures")]
        public AccountCreateIdentityAttestationsTermsOfServiceConsumerPrivacyDisclosuresOptions ConsumerPrivacyDisclosures { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Crypto-specific terms of service.
        /// </summary>
        [JsonProperty("crypto_money_manager")]
        [STJS.JsonPropertyName("crypto_money_manager")]
        public AccountCreateIdentityAttestationsTermsOfServiceCryptoMoneyManagerOptions CryptoMoneyManager { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Treasury-specific terms of service.
        /// </summary>
        [JsonProperty("money_manager")]
        [STJS.JsonPropertyName("money_manager")]
        public AccountCreateIdentityAttestationsTermsOfServiceMoneyManagerOptions MoneyManager { get; set; }
    }
}

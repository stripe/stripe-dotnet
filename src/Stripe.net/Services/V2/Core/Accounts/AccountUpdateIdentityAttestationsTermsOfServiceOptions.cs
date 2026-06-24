// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityAttestationsTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Account's acceptance of the <a
        /// href="https://docs.stripe.com/connect/updating-accounts#tos-acceptance">Stripe Services
        /// Agreement</a>.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public AccountUpdateIdentityAttestationsTermsOfServiceAccountOptions Account { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Crypto-specific terms of service.
        /// </summary>
        [JsonProperty("crypto_money_manager")]
        [STJS.JsonPropertyName("crypto_money_manager")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCryptoMoneyManagerOptions CryptoMoneyManager { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Treasury-specific terms of service.
        /// </summary>
        [JsonProperty("money_manager")]
        [STJS.JsonPropertyName("money_manager")]
        public AccountUpdateIdentityAttestationsTermsOfServiceMoneyManagerOptions MoneyManager { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientDataFeatures : StripeEntity<AccountConfigurationRecipientDataFeatures>
    {
        /// <summary>
        /// Features that enable OutboundPayments to a bank account linked to this Account.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountConfigurationRecipientDataFeaturesBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Features that enable OutboundPayments to a card linked to this Account.
        /// </summary>
        [JsonProperty("cards")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cards")]
#endif
        public AccountConfigurationRecipientDataFeaturesCards Cards { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientDataFeaturesBankAccounts : StripeEntity<AccountConfigurationRecipientDataFeaturesBankAccounts>
    {
        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local")]
#endif
        public AccountConfigurationRecipientDataFeaturesBankAccountsLocal Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over wire.
        /// </summary>
        [JsonProperty("wire")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wire")]
#endif
        public AccountConfigurationRecipientDataFeaturesBankAccountsWire Wire { get; set; }
    }
}

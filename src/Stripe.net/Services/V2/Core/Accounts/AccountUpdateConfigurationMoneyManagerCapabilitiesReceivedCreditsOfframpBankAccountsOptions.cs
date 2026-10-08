// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Can receive BRL converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can receive COP converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsCopOptions Cop { get; set; }

        /// <summary>
        /// Can receive EUR converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsEurOptions Eur { get; set; }

        /// <summary>
        /// Can receive GBP converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can receive MXN converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can receive USD converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsUsdOptions Usd { get; set; }
    }
}

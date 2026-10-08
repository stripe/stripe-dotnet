// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Can receive BRL converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can receive COP converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsCopOptions Cop { get; set; }

        /// <summary>
        /// Can receive EUR converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsEurOptions Eur { get; set; }

        /// <summary>
        /// Can receive GBP converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can receive MXN converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can receive USD converted from crypto through a bank-account-like financial address.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsUsdOptions Usd { get; set; }
    }
}

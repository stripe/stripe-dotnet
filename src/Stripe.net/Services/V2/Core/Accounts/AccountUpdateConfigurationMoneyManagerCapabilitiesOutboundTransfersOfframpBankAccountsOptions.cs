// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Can send crypto converted into BRL to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can send crypto converted into COP to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsCopOptions Cop { get; set; }

        /// <summary>
        /// Can send crypto converted into EUR to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsEurOptions Eur { get; set; }

        /// <summary>
        /// Can send crypto converted into GBP to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can send crypto converted into MXN to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can send crypto converted into USD to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsUsdOptions Usd { get; set; }
    }
}

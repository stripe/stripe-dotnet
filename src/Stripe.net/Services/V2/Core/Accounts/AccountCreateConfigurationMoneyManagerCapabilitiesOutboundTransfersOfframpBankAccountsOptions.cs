// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Can send crypto converted into BRL to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can send crypto converted into COP to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsCopOptions Cop { get; set; }

        /// <summary>
        /// Can send crypto converted into EUR to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsEurOptions Eur { get; set; }

        /// <summary>
        /// Can send crypto converted into GBP to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can send crypto converted into MXN to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can send crypto converted into USD to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOfframpBankAccountsUsdOptions Usd { get; set; }
    }
}

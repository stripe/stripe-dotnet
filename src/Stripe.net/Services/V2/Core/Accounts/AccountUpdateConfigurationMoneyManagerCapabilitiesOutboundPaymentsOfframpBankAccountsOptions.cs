// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Can send crypto converted into BRL to a bank account.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can send crypto converted into COP to a bank account.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsCopOptions Cop { get; set; }

        /// <summary>
        /// Can send crypto converted into EUR to a bank account.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsEurOptions Eur { get; set; }

        /// <summary>
        /// Can send crypto converted into GBP to a bank account.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can send crypto converted into MXN to a bank account.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can send crypto converted into USD to a bank account.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsUsdOptions Usd { get; set; }
    }
}

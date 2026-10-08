// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccounts : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccounts>
    {
        /// <summary>
        /// Can send crypto converted into BRL to a bank account.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsBrl Brl { get; set; }

        /// <summary>
        /// Can send crypto converted into COP to a bank account.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsCop Cop { get; set; }

        /// <summary>
        /// Can send crypto converted into EUR to a bank account.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsEur Eur { get; set; }

        /// <summary>
        /// Can send crypto converted into GBP to a bank account.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsGbp Gbp { get; set; }

        /// <summary>
        /// Can send crypto converted into MXN to a bank account.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsMxn Mxn { get; set; }

        /// <summary>
        /// Can send crypto converted into USD to a bank account.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOfframpBankAccountsUsd Usd { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilities : StripeEntity<AccountConfigurationStorerCapabilities>
    {
        /// <summary>
        /// Hash containing capabilities related to consumer financial accounts.
        /// </summary>
        [JsonProperty("consumer")]
        [STJS.JsonPropertyName("consumer")]
        public AccountConfigurationStorerCapabilitiesConsumer Consumer { get; set; }

        /// <summary>
        /// Can provision a financial address to credit/debit a FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
        [STJS.JsonPropertyName("financial_addresses")]
        public AccountConfigurationStorerCapabilitiesFinancialAddresses FinancialAddresses { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public AccountConfigurationStorerCapabilitiesHoldsCurrencies HoldsCurrencies { get; set; }

        /// <summary>
        /// Hash containing capabilities related to InboundTransfers.
        /// </summary>
        [JsonProperty("inbound_transfers")]
        [STJS.JsonPropertyName("inbound_transfers")]
        public AccountConfigurationStorerCapabilitiesInboundTransfers InboundTransfers { get; set; }

        /// <summary>
        /// Hash containing capabilities related to <a
        /// href="https://stripe.com/api/treasury/outbound_payments?api-version=preview">OutboundPayments</a>.
        /// </summary>
        [JsonProperty("outbound_payments")]
        [STJS.JsonPropertyName("outbound_payments")]
        public AccountConfigurationStorerCapabilitiesOutboundPayments OutboundPayments { get; set; }

        /// <summary>
        /// Hash containing capabilities related to <a
        /// href="https://stripe.com/api/treasury/outbound_transfers?api-version=preview">OutboundTransfers</a>.
        /// </summary>
        [JsonProperty("outbound_transfers")]
        [STJS.JsonPropertyName("outbound_transfers")]
        public AccountConfigurationStorerCapabilitiesOutboundTransfers OutboundTransfers { get; set; }
    }
}

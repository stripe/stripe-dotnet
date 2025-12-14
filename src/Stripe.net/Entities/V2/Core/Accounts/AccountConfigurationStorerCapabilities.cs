// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorerCapabilities : StripeEntity<AccountConfigurationStorerCapabilities>
    {
        /// <summary>
        /// Can provision a financial address to credit/debit a FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_addresses")]
#endif
        public AccountConfigurationStorerCapabilitiesFinancialAddresses FinancialAddresses { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("holds_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("holds_currencies")]
#endif
        public AccountConfigurationStorerCapabilitiesHoldsCurrencies HoldsCurrencies { get; set; }

        /// <summary>
        /// Hash containing capabilities related to InboundTransfers.
        /// </summary>
        [JsonProperty("inbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_transfers")]
#endif
        public AccountConfigurationStorerCapabilitiesInboundTransfers InboundTransfers { get; set; }

        /// <summary>
        /// Hash containing capabilities related to <a
        /// href="https://stripe.com/api/treasury/outbound_payments?api-version=preview">OutboundPayments</a>.
        /// </summary>
        [JsonProperty("outbound_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payments")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundPayments OutboundPayments { get; set; }

        /// <summary>
        /// Hash containing capabilities related to <a
        /// href="https://stripe.com/api/treasury/outbound_transfers?api-version=preview">OutboundTransfers</a>.
        /// </summary>
        [JsonProperty("outbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfers")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundTransfers OutboundTransfers { get; set; }
    }
}

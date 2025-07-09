// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationStorerCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Can provision a financial address to credit/debit a FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_addresses")]
#endif
        public AccountCreateConfigurationStorerCapabilitiesFinancialAddressesOptions FinancialAddresses { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("holds_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("holds_currencies")]
#endif
        public AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesOptions HoldsCurrencies { get; set; }

        /// <summary>
        /// Can pull funds from an external source, owned by yourself, to a FinancialAccount.
        /// </summary>
        [JsonProperty("inbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_transfers")]
#endif
        public AccountCreateConfigurationStorerCapabilitiesInboundTransfersOptions InboundTransfers { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by someone else.
        /// </summary>
        [JsonProperty("outbound_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payments")]
#endif
        public AccountCreateConfigurationStorerCapabilitiesOutboundPaymentsOptions OutboundPayments { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by yourself.
        /// </summary>
        [JsonProperty("outbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfers")]
#endif
        public AccountCreateConfigurationStorerCapabilitiesOutboundTransfersOptions OutboundTransfers { get; set; }
    }
}

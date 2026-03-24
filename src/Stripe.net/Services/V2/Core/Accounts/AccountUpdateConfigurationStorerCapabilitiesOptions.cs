// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationStorerCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Can provision a consumer financial account.
        /// </summary>
        [JsonProperty("consumer")]
        [STJS.JsonPropertyName("consumer")]
        public AccountUpdateConfigurationStorerCapabilitiesConsumerOptions Consumer { get; set; }

        /// <summary>
        /// Can provision a financial address to credit/debit a FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
        [STJS.JsonPropertyName("financial_addresses")]
        public AccountUpdateConfigurationStorerCapabilitiesFinancialAddressesOptions FinancialAddresses { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public AccountUpdateConfigurationStorerCapabilitiesHoldsCurrenciesOptions HoldsCurrencies { get; set; }

        /// <summary>
        /// Can pull funds from an external source, owned by yourself, to a FinancialAccount.
        /// </summary>
        [JsonProperty("inbound_transfers")]
        [STJS.JsonPropertyName("inbound_transfers")]
        public AccountUpdateConfigurationStorerCapabilitiesInboundTransfersOptions InboundTransfers { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by someone else.
        /// </summary>
        [JsonProperty("outbound_payments")]
        [STJS.JsonPropertyName("outbound_payments")]
        public AccountUpdateConfigurationStorerCapabilitiesOutboundPaymentsOptions OutboundPayments { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by yourself.
        /// </summary>
        [JsonProperty("outbound_transfers")]
        [STJS.JsonPropertyName("outbound_transfers")]
        public AccountUpdateConfigurationStorerCapabilitiesOutboundTransfersOptions OutboundTransfers { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilities : StripeEntity<AccountConfigurationMoneyManagerCapabilities>
    {
        /// <summary>
        /// Can send or receive business storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("business_storage")]
        [STJS.JsonPropertyName("business_storage")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorage BusinessStorage { get; set; }

        /// <summary>
        /// Hash containing capabilities related to InboundTransfers.
        /// </summary>
        [JsonProperty("inbound_transfers")]
        [STJS.JsonPropertyName("inbound_transfers")]
        public AccountConfigurationMoneyManagerCapabilitiesInboundTransfers InboundTransfers { get; set; }

        /// <summary>
        /// Hash containing capabilities related to <a
        /// href="https://stripe.com/api/treasury/outbound_payments?api-version=preview">OutboundPayments</a>.
        /// </summary>
        [JsonProperty("outbound_payments")]
        [STJS.JsonPropertyName("outbound_payments")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundPayments OutboundPayments { get; set; }

        /// <summary>
        /// Hash containing capabilities related to <a
        /// href="https://stripe.com/api/treasury/outbound_transfers?api-version=preview">OutboundTransfers</a>.
        /// </summary>
        [JsonProperty("outbound_transfers")]
        [STJS.JsonPropertyName("outbound_transfers")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundTransfers OutboundTransfers { get; set; }

        /// <summary>
        /// Hash containing capabilities related to ReceivedCredits.
        /// </summary>
        [JsonProperty("received_credits")]
        [STJS.JsonPropertyName("received_credits")]
        public AccountConfigurationMoneyManagerCapabilitiesReceivedCredits ReceivedCredits { get; set; }

        /// <summary>
        /// Hash containing capabilities related to ReceivedDebits.
        /// </summary>
        [JsonProperty("received_debits")]
        [STJS.JsonPropertyName("received_debits")]
        public AccountConfigurationMoneyManagerCapabilitiesReceivedDebits ReceivedDebits { get; set; }
    }
}

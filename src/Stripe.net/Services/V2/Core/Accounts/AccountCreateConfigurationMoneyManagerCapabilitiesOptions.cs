// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Can send or receive business storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("business_storage")]
        [STJS.JsonPropertyName("business_storage")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageOptions BusinessStorage { get; set; }

        /// <summary>
        /// Can send or receive consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("consumer_storage")]
        [STJS.JsonPropertyName("consumer_storage")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesConsumerStorageOptions ConsumerStorage { get; set; }

        /// <summary>
        /// Can pull funds from an external source, owned by yourself, to a FinancialAccount.
        /// </summary>
        [JsonProperty("inbound_transfers")]
        [STJS.JsonPropertyName("inbound_transfers")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesInboundTransfersOptions InboundTransfers { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by someone else.
        /// </summary>
        [JsonProperty("outbound_payments")]
        [STJS.JsonPropertyName("outbound_payments")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOptions OutboundPayments { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by yourself.
        /// </summary>
        [JsonProperty("outbound_transfers")]
        [STJS.JsonPropertyName("outbound_transfers")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOptions OutboundTransfers { get; set; }

        /// <summary>
        /// Can receive funds into a FinancialAccount.
        /// </summary>
        [JsonProperty("received_credits")]
        [STJS.JsonPropertyName("received_credits")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOptions ReceivedCredits { get; set; }

        /// <summary>
        /// Can receive debits to a FinancialAccount.
        /// </summary>
        [JsonProperty("received_debits")]
        [STJS.JsonPropertyName("received_debits")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedDebitsOptions ReceivedDebits { get; set; }
    }
}

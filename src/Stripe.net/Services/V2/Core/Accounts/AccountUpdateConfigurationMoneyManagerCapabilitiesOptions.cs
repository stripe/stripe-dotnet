// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Can send or receive business storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("business_storage")]
        [STJS.JsonPropertyName("business_storage")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageOptions BusinessStorage { get; set; }

        /// <summary>
        /// Can send or receive consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("consumer_storage")]
        [STJS.JsonPropertyName("consumer_storage")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesConsumerStorageOptions ConsumerStorage { get; set; }

        /// <summary>
        /// Can pull funds from an external source, owned by yourself, to a FinancialAccount.
        /// </summary>
        [JsonProperty("inbound_transfers")]
        [STJS.JsonPropertyName("inbound_transfers")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesInboundTransfersOptions InboundTransfers { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by someone else.
        /// </summary>
        [JsonProperty("outbound_payments")]
        [STJS.JsonPropertyName("outbound_payments")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOptions OutboundPayments { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a destination owned by yourself.
        /// </summary>
        [JsonProperty("outbound_transfers")]
        [STJS.JsonPropertyName("outbound_transfers")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundTransfersOptions OutboundTransfers { get; set; }

        /// <summary>
        /// Can receive funds on a financial address to credit a FinancialAccount.
        /// </summary>
        [JsonProperty("received_credits")]
        [STJS.JsonPropertyName("received_credits")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOptions ReceivedCredits { get; set; }

        /// <summary>
        /// Can receive debits to a FinancialAccount.
        /// </summary>
        [JsonProperty("received_debits")]
        [STJS.JsonPropertyName("received_debits")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedDebitsOptions ReceivedDebits { get; set; }
    }
}

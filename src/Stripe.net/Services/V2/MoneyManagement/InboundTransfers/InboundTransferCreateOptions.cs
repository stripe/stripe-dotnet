// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferCreateOptions : BaseOptions
    {
        /// <summary>
        /// The amount and currency to credit to the FinancialAccount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// An optional, freeform description field intended to store metadata.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The verified bank account credential to debit for this InboundTransfer.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public InboundTransferCreateFromOptions From { get; set; }

        /// <summary>
        /// Network-specific details for the InboundTransfer.
        /// </summary>
        [JsonProperty("network_details")]
        [STJS.JsonPropertyName("network_details")]
        public InboundTransferCreateNetworkDetailsOptions NetworkDetails { get; set; }

        /// <summary>
        /// An optional statement descriptor surfaced on the payer's bank statement. Max 10
        /// characters. When omitted, Stripe sends its default descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The FinancialAccount and currency to credit with the transferred funds.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public InboundTransferCreateToOptions To { get; set; }
    }
}

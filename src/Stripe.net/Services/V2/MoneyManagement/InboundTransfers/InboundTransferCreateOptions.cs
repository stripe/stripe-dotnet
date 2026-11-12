// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferCreateOptions : BaseOptions, IHasMetadata
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
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The FinancialAccount and currency to credit with the transferred funds.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public InboundTransferCreateToOptions To { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The "presentment amount" for the OutboundPayment.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Delivery options to be used to send the OutboundTransfer.
        /// </summary>
        [JsonProperty("delivery_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_options")]
#endif
        public OutboundTransferCreateDeliveryOptionsOptions DeliveryOptions { get; set; }

        /// <summary>
        /// An arbitrary string attached to the OutboundTransfer. Often useful for displaying to
        /// users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount to pull funds from.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public OutboundTransferCreateFromOptions From { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// To which payout method to send the OutboundTransfer.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public OutboundTransferCreateToOptions To { get; set; }
    }
}

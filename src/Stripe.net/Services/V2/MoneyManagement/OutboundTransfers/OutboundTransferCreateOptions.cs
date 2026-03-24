// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The "presentment amount" for the OutboundPayment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Delivery options to be used to send the OutboundTransfer.
        /// </summary>
        [JsonProperty("delivery_options")]
        [STJS.JsonPropertyName("delivery_options")]
        public OutboundTransferCreateDeliveryOptionsOptions DeliveryOptions { get; set; }

        /// <summary>
        /// An arbitrary string attached to the OutboundTransfer. Often useful for displaying to
        /// users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount to pull funds from.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public OutboundTransferCreateFromOptions From { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The recipient verification id for this OutboundTransfer. Only required for countries
        /// with regulatory mandates to verify recipient names before OutboundTransfer creation.
        /// </summary>
        [JsonProperty("recipient_verification")]
        [STJS.JsonPropertyName("recipient_verification")]
        public string RecipientVerification { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for an OutboundTransfer (for example,
        /// on a bank statement). Must be between 3 and 22 characters long, and not contain
        /// profanity.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// To which payout method to send the OutboundTransfer.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public OutboundTransferCreateToOptions To { get; set; }
    }
}

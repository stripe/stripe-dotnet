// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// An InboundTransfer object, representing a money movement from a user owned PaymentMethod
    /// to a FinancialAccount belonging to the same user.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransfer : StripeEntity<InboundTransfer>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the InboundTransfer.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The amount in specified currency that will land in the FinancialAccount balance.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Creation time of the InboundTransfer. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A freeform text field provided by user, containing metadata.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A nested object containing information about the origin of the InboundTransfer.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public InboundTransferFrom From { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A hosted transaction receipt URL that is provided when money movement is considered
        /// regulated under Stripe’s money transmission licenses.
        /// </summary>
        [JsonProperty("receipt_url")]
        [STJS.JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// A nested object containing information about the destination of the InboundTransfer.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public InboundTransferTo To { get; set; }

        /// <summary>
        /// A list of history objects, representing changes in the state of the InboundTransfer.
        /// </summary>
        [JsonProperty("transfer_history")]
        [STJS.JsonPropertyName("transfer_history")]
        public List<InboundTransferTransferHistory> TransferHistory { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// An InboundTransfer object, representing a money movement from a user owned PaymentMethod
    /// to a FinancialAccount belonging to the same user.
    /// </summary>
    public class InboundTransfer : StripeEntity<InboundTransfer>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the InboundTransfer.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The amount in specified currency that will land in the FinancialAccount balance.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public Amount Amount { get; set; }

        /// <summary>
        /// Creation time of the InboundTransfer. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A freeform text field provided by user, containing metadata.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// A nested object containing information about the origin of the InboundTransfer.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public InboundTransferFrom From { get; set; }

        /// <summary>
        /// A hosted transaction receipt URL that is provided when money movement is considered
        /// regulated under Stripe’s money transmission licenses.
        /// </summary>
        [JsonProperty("receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_url")]
#endif
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// A nested object containing information about the destination of the InboundTransfer.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public InboundTransferTo To { get; set; }

        /// <summary>
        /// A list of history objects, representing changes in the state of the InboundTransfer.
        /// </summary>
        [JsonProperty("transfer_history")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_history")]
#endif
        public List<InboundTransferTransferHistory> TransferHistory { get; set; }
    }
}

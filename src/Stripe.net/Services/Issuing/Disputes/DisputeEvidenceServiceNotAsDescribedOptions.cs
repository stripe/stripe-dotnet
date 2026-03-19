// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceServiceNotAsDescribedOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation")]
        [STJS.JsonPropertyName("additional_documentation")]
        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// Date when order was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for canceling the order.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        [STJS.JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
        [STJS.JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Date when the product was received.
        /// </summary>
        [JsonProperty("received_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("received_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ReceivedAt { get; set; }
    }
}

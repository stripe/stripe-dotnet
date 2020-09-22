// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeEvidenceServiceNotAsDescribedOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation")]
        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// Date when order was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for canceling the order.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Date when the product was received.
        /// </summary>
        [JsonProperty("received_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReceivedAt { get; set; }
    }
}

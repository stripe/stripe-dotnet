// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeEvidenceCanceledOptions : INestedOptions
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
        /// Whether the cardholder was provided with a cancellation policy.
        /// </summary>
        [JsonProperty("cancellation_policy_provided")]
        public bool? CancellationPolicyProvided { get; set; }

        /// <summary>
        /// Reason for canceling the order.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Date when the cardholder expected to receive the product.
        /// </summary>
        [JsonProperty("expected_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpectedAt { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Description of the merchandise or service that was purchased.
        /// </summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Whether the product was a merchandise or service.
        /// One of: <c>merchandise</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// Result of cardholder's attempt to return the product.
        /// One of: <c>merchant_rejected</c>, or <c>successful</c>.
        /// </summary>
        [JsonProperty("return_status")]
        public string ReturnStatus { get; set; }

        /// <summary>
        /// Date when the product was returned or attempted to be returned.
        /// </summary>
        [JsonProperty("returned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReturnedAt { get; set; }
    }
}

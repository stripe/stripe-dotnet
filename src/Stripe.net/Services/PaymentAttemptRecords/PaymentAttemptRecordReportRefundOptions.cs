// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentAttemptRecordReportRefundOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>
        /// representing how much of this payment to refund. Can refund only up to the remaining,
        /// unrefunded amount of the payment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public PaymentAttemptRecordAmountOptions Amount { get; set; }

        /// <summary>
        /// When the reported refund was initiated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("initiated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("initiated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? InitiatedAt { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The outcome of the reported refund.
        /// </summary>
        [JsonProperty("outcome")]
        [STJS.JsonPropertyName("outcome")]
        public string Outcome { get; set; }

        /// <summary>
        /// Processor information for this refund.
        /// </summary>
        [JsonProperty("processor_details")]
        [STJS.JsonPropertyName("processor_details")]
        public PaymentAttemptRecordProcessorDetailsOptions ProcessorDetails { get; set; }

        /// <summary>
        /// Information about the payment attempt refund.
        /// </summary>
        [JsonProperty("refunded")]
        [STJS.JsonPropertyName("refunded")]
        public PaymentAttemptRecordRefundedOptions Refunded { get; set; }
    }
}

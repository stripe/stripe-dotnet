// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordReportRefundOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>
        /// representing how much of this payment to refund. Can refund only up to the remaining,
        /// unrefunded amount of the payment.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public PaymentRecordAmountOptions Amount { get; set; }

        /// <summary>
        /// When the reported refund was initiated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("initiated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("initiated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? InitiatedAt { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The outcome of the reported refund.
        /// </summary>
        [JsonProperty("outcome")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outcome")]
#endif
        public string Outcome { get; set; }

        /// <summary>
        /// Processor information for this refund.
        /// </summary>
        [JsonProperty("processor_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("processor_details")]
#endif
        public PaymentRecordProcessorDetailsOptions ProcessorDetails { get; set; }

        /// <summary>
        /// Information about the payment attempt refund.
        /// </summary>
        [JsonProperty("refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunded")]
#endif
        public PaymentRecordRefundedOptions Refunded { get; set; }
    }
}

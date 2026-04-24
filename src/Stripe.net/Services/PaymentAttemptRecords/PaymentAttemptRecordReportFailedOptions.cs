// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentAttemptRecordReportFailedOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// When the reported payment failed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("failed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// The failure code for this payment attempt. Must be one of
        /// <c>payment_method_customer_decline</c> or
        /// <c>payment_method_provider_unknown_outcome</c>.
        /// One of: <c>payment_method_customer_decline</c>, or
        /// <c>payment_method_provider_unknown_outcome</c>.
        /// </summary>
        [JsonProperty("failure_code")]
        [STJS.JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Processor information for this payment.
        /// </summary>
        [JsonProperty("processor_details")]
        [STJS.JsonPropertyName("processor_details")]
        public PaymentAttemptRecordProcessorDetailsOptions ProcessorDetails { get; set; }
    }
}

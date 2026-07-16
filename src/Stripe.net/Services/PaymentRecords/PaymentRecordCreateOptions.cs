// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordCreateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// The amount that has been lost to the customer due to disputes on this payment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public PaymentRecordAmountOptions Amount { get; set; }

        /// <summary>
        /// Information about the dispute closing.
        /// </summary>
        [JsonProperty("closed")]
        [STJS.JsonPropertyName("closed")]
        public PaymentRecordClosedOptions Closed { get; set; }

        /// <summary>
        /// Information about the dispute funding event.
        /// </summary>
        [JsonProperty("funded")]
        [STJS.JsonPropertyName("funded")]
        public PaymentRecordFundedOptions Funded { get; set; }

        /// <summary>
        /// When the reported payment was initiated. Measured in seconds since the Unix epoch.
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
        public PaymentRecordProcessorDetailsOptions ProcessorDetails { get; set; }

        /// <summary>
        /// The reason the payment was disputed.
        /// One of: <c>bank_cannot_process</c>, <c>check_returned</c>, <c>credit_not_processed</c>,
        /// <c>customer_initiated</c>, <c>debit_not_authorized</c>, <c>duplicate</c>,
        /// <c>fraudulent</c>, <c>general</c>, <c>incorrect_account_details</c>,
        /// <c>insufficient_funds</c>, <c>noncompliant</c>, <c>product_not_received</c>,
        /// <c>product_unacceptable</c>, <c>subscription_canceled</c>, or <c>unrecognized</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}

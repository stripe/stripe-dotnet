// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceCanceledOptions : INestedOptions, IHasSetTracking
    {
        private string additionalDocumentation;
        private DateTime? canceledAt;
        private bool? cancellationPolicyProvided;
        private string cancellationReason;
        private DateTime? expectedAt;
        private string explanation;
        private string productDescription;
        private string productType;
        private string returnStatus;
        private DateTime? returnedAt;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("additional_documentation")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string AdditionalDocumentation
        {
            get => this.additionalDocumentation;
            set
            {
                this.additionalDocumentation = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Date when order was canceled.
        /// </summary>
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CanceledAt
        {
            get => this.canceledAt;
            set
            {
                this.canceledAt = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether the cardholder was provided with a cancellation policy.
        /// </summary>
        [JsonProperty("cancellation_policy_provided", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("cancellation_policy_provided")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? CancellationPolicyProvided
        {
            get => this.cancellationPolicyProvided;
            set
            {
                this.cancellationPolicyProvided = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Reason for canceling the order.
        /// </summary>
        [JsonProperty("cancellation_reason", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("cancellation_reason")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CancellationReason
        {
            get => this.cancellationReason;
            set
            {
                this.cancellationReason = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Date when the cardholder expected to receive the product.
        /// </summary>
        [JsonProperty("expected_at", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expected_at")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpectedAt
        {
            get => this.expectedAt;
            set
            {
                this.expectedAt = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("explanation")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Explanation
        {
            get => this.explanation;
            set
            {
                this.explanation = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Description of the merchandise or service that was purchased.
        /// </summary>
        [JsonProperty("product_description", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("product_description")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ProductDescription
        {
            get => this.productDescription;
            set
            {
                this.productDescription = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether the product was a merchandise or service.
        /// One of: <c>merchandise</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("product_type")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ProductType
        {
            get => this.productType;
            set
            {
                this.productType = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Result of cardholder's attempt to return the product.
        /// One of: <c>merchant_rejected</c>, or <c>successful</c>.
        /// </summary>
        [JsonProperty("return_status", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("return_status")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ReturnStatus
        {
            get => this.returnStatus;
            set
            {
                this.returnStatus = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Date when the product was returned or attempted to be returned.
        /// </summary>
        [JsonProperty("returned_at", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("returned_at")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ReturnedAt
        {
            get => this.returnedAt;
            set
            {
                this.returnedAt = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

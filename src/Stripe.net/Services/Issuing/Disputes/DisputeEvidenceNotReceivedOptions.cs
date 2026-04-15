// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceNotReceivedOptions : INestedOptions, IHasSetTracking
    {
        private string additionalDocumentation;
        private DateTime? expectedAt;
        private string explanation;
        private string productDescription;
        private string productType;

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

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

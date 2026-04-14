// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceMerchandiseNotAsDescribedOptions : INestedOptions, IHasSetTracking
    {
        private string additionalDocumentation;
        private string explanation;
        private DateTime? receivedAt;
        private string returnDescription;
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
        /// Date when the product was received.
        /// </summary>
        [JsonProperty("received_at", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("received_at")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ReceivedAt
        {
            get => this.receivedAt;
            set
            {
                this.receivedAt = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Description of the cardholder's attempt to return the product.
        /// </summary>
        [JsonProperty("return_description", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("return_description")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ReturnDescription
        {
            get => this.returnDescription;
            set
            {
                this.returnDescription = value;
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

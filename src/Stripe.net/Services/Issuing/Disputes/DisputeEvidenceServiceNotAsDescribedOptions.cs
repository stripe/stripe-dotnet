// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceServiceNotAsDescribedOptions : INestedOptions, IHasSetTracking
    {
        private string additionalDocumentation;
        private DateTime? canceledAt;
        private string cancellationReason;
        private string explanation;
        private DateTime? receivedAt;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation")]
        [STJS.JsonPropertyName("additional_documentation")]
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
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("canceled_at")]
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
        /// Reason for canceling the order.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        [STJS.JsonPropertyName("cancellation_reason")]
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
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
        [STJS.JsonPropertyName("explanation")]
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
        [JsonProperty("received_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("received_at")]
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

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

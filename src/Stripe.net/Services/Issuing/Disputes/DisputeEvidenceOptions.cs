// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceOptions : INestedOptions, IHasSetTracking
    {
        private DisputeEvidenceCanceledOptions canceled;
        private DisputeEvidenceDuplicateOptions duplicate;
        private DisputeEvidenceFraudulentOptions fraudulent;
        private DisputeEvidenceMerchandiseNotAsDescribedOptions merchandiseNotAsDescribed;
        private DisputeEvidenceNoValidAuthorizationOptions noValidAuthorization;
        private DisputeEvidenceNotReceivedOptions notReceived;
        private DisputeEvidenceOtherOptions other;
        private DisputeEvidenceServiceNotAsDescribedOptions serviceNotAsDescribed;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'canceled'.
        /// </summary>
        [JsonProperty("canceled", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("canceled")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceCanceledOptions Canceled
        {
            get => this.canceled;
            set
            {
                this.canceled = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'duplicate'.
        /// </summary>
        [JsonProperty("duplicate", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("duplicate")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceDuplicateOptions Duplicate
        {
            get => this.duplicate;
            set
            {
                this.duplicate = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'fraudulent'.
        /// </summary>
        [JsonProperty("fraudulent", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("fraudulent")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceFraudulentOptions Fraudulent
        {
            get => this.fraudulent;
            set
            {
                this.fraudulent = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'merchandise_not_as_described'.
        /// </summary>
        [JsonProperty("merchandise_not_as_described", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("merchandise_not_as_described")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceMerchandiseNotAsDescribedOptions MerchandiseNotAsDescribed
        {
            get => this.merchandiseNotAsDescribed;
            set
            {
                this.merchandiseNotAsDescribed = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'no_valid_authorization'.
        /// </summary>
        [JsonProperty("no_valid_authorization", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("no_valid_authorization")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceNoValidAuthorizationOptions NoValidAuthorization
        {
            get => this.noValidAuthorization;
            set
            {
                this.noValidAuthorization = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'not_received'.
        /// </summary>
        [JsonProperty("not_received", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("not_received")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceNotReceivedOptions NotReceived
        {
            get => this.notReceived;
            set
            {
                this.notReceived = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'other'.
        /// </summary>
        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("other")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceOtherOptions Other
        {
            get => this.other;
            set
            {
                this.other = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The reason for filing the dispute. The evidence should be submitted in the field of the
        /// same name.
        /// One of: <c>canceled</c>, <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>merchandise_not_as_described</c>, <c>no_valid_authorization</c>, <c>not_received</c>,
        /// <c>other</c>, or <c>service_not_as_described</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'service_not_as_described'.
        /// </summary>
        [JsonProperty("service_not_as_described", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("service_not_as_described")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public DisputeEvidenceServiceNotAsDescribedOptions ServiceNotAsDescribed
        {
            get => this.serviceNotAsDescribed;
            set
            {
                this.serviceNotAsDescribed = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

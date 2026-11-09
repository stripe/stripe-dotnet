// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsPauseScheduleOptions : INestedOptions, IHasSetTracking
    {
        private InvoiceScheduleDetailsPauseScheduleResumeOptions resume;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// A unique identifier for this pause schedule entry.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Configuration for when and how the subscription pauses.
        /// </summary>
        [JsonProperty("pause")]
        [STJS.JsonPropertyName("pause")]
        public InvoiceScheduleDetailsPauseSchedulePauseOptions Pause { get; set; }

        /// <summary>
        /// Configuration for when and how the subscription resumes.
        /// </summary>
        [JsonProperty("resume", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("resume")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoiceScheduleDetailsPauseScheduleResumeOptions Resume
        {
            get => this.resume;
            set
            {
                this.resume = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

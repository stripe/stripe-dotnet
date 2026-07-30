// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentRadarOptionsOptions : INestedOptions, IHasSetTracking
    {
        private string referrer;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The referrer URL of the current checkout session. You can use this to supply
        /// session-level referrer data when a Radar Session isn't available or doesn't contain a
        /// referrer.
        /// </summary>
        [JsonProperty("referrer", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("referrer")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Referrer
        {
            get => this.referrer;
            set
            {
                this.referrer = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A <a href="https://docs.stripe.com/radar/radar-session">Radar Session</a> is a snapshot
        /// of the browser metadata and device details that help Radar make more accurate
        /// predictions on your payments.
        /// </summary>
        [JsonProperty("session")]
        [STJS.JsonPropertyName("session")]
        public string Session { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

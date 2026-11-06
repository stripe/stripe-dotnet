// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentRadarOptions : StripeEntity<SetupIntentRadarOptions>
    {
        /// <summary>
        /// The value you provided for whether this transaction starts a free trial. This is null if
        /// you haven't explicitly set it.
        /// </summary>
        [JsonProperty("is_free_trial_transaction")]
        [STJS.JsonPropertyName("is_free_trial_transaction")]
        public bool? IsFreeTrialTransaction { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/radar/radar-session">Radar Session</a> is a snapshot
        /// of the browser metadata and device details that help Radar make more accurate
        /// predictions on your payments.
        /// </summary>
        [JsonProperty("session")]
        [STJS.JsonPropertyName("session")]
        public string Session { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentRadarOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Whether this transaction starts a free trial. Set to <c>true</c> for a free trial or
        /// <c>false</c> otherwise. If omitted, retains the previously set value. If never set,
        /// Stripe uses Billing or metadata to determine trial status.
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

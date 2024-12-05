// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodDataRadarOptionsOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://stripe.com/docs/radar/radar-session">Radar Session</a> is a snapshot
        /// of the browser metadata and device details that help Radar make more accurate
        /// predictions on your payments.
        /// </summary>
        [JsonProperty("session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("session")]
#endif
        public string Session { get; set; }
    }
}

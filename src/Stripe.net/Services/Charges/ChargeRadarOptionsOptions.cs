// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargeRadarOptionsOptions : INestedOptions
    {
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

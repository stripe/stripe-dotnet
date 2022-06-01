// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeRadarOptionsOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://stripe.com/docs/radar/radar-session">Radar Session</a> is a snapshot
        /// of the browser metadata and device details that help Radar make more accurate
        /// predictions on your payments.
        /// </summary>
        [JsonProperty("session")]
        public string Session { get; set; }
    }
}

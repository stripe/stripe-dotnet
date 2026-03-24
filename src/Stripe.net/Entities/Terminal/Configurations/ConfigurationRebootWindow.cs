// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationRebootWindow : StripeEntity<ConfigurationRebootWindow>
    {
        /// <summary>
        /// Integer between 0 to 23 that represents the end hour of the reboot time window. The
        /// value must be different than the start_hour.
        /// </summary>
        [JsonProperty("end_hour")]
        [STJS.JsonPropertyName("end_hour")]
        public long EndHour { get; set; }

        /// <summary>
        /// Integer between 0 to 23 that represents the start hour of the reboot time window.
        /// </summary>
        [JsonProperty("start_hour")]
        [STJS.JsonPropertyName("start_hour")]
        public long StartHour { get; set; }
    }
}

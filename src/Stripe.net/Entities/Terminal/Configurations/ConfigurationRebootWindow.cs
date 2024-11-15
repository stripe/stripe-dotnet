// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationRebootWindow : StripeEntity<ConfigurationRebootWindow>
    {
        /// <summary>
        /// Integer between 0 to 23 that represents the end hour of the reboot time window. The
        /// value must be different than the start_hour.
        /// </summary>
        [JsonProperty("end_hour")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_hour")]
#endif

        public long EndHour { get; set; }

        /// <summary>
        /// Integer between 0 to 23 that represents the start hour of the reboot time window.
        /// </summary>
        [JsonProperty("start_hour")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_hour")]
#endif

        public long StartHour { get; set; }
    }
}

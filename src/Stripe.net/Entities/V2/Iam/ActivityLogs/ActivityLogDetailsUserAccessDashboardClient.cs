// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserAccessDashboardClient : StripeEntity<ActivityLogDetailsUserAccessDashboardClient>
    {
        /// <summary>
        /// Browser used for the user access action.
        /// </summary>
        [JsonProperty("browser")]
        [STJS.JsonPropertyName("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// Browser version used for the user access action.
        /// </summary>
        [JsonProperty("browser_version")]
        [STJS.JsonPropertyName("browser_version")]
        public string BrowserVersion { get; set; }

        /// <summary>
        /// Device type used for the user access action.
        /// </summary>
        [JsonProperty("device_type")]
        [STJS.JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// Operating system used for the user access action.
        /// </summary>
        [JsonProperty("os")]
        [STJS.JsonPropertyName("os")]
        public string Os { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsConnectOldExpressBrandingSettings : StripeEntity<ActivityLogDetailsConnectOldExpressBrandingSettings>
    {
        /// <summary>
        /// Border radius for the Express Dashboard.
        /// </summary>
        [JsonProperty("border_radius")]
        [STJS.JsonPropertyName("border_radius")]
        public string BorderRadius { get; set; }

        /// <summary>
        /// Primary button background color for the Express Dashboard.
        /// </summary>
        [JsonProperty("primary_button_background_color")]
        [STJS.JsonPropertyName("primary_button_background_color")]
        public string PrimaryButtonBackgroundColor { get; set; }

        /// <summary>
        /// Primary color for the Express Dashboard.
        /// </summary>
        [JsonProperty("primary_color")]
        [STJS.JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// Secondary button background color for the Express Dashboard.
        /// </summary>
        [JsonProperty("secondary_button_background_color")]
        [STJS.JsonPropertyName("secondary_button_background_color")]
        public string SecondaryButtonBackgroundColor { get; set; }
    }
}

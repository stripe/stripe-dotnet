// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserAccessRiskSignal : StripeEntity<ActivityLogDetailsUserAccessRiskSignal>
    {
        /// <summary>
        /// The user access action used a novel device.
        /// </summary>
        [JsonProperty("novel_device")]
        [STJS.JsonPropertyName("novel_device")]
        public ActivityLogDetailsUserAccessRiskSignalNovelDevice NovelDevice { get; set; }

        /// <summary>
        /// Type of risk signal.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

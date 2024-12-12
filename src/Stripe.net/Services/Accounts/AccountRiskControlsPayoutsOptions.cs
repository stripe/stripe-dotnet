// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRiskControlsPayoutsOptions : INestedOptions
    {
        /// <summary>
        /// To request to pause a risk control, pass <c>true</c>. To request to unpause a risk
        /// control, pass <c>false</c>. There can be a delay before the risk control is paused or
        /// unpaused.
        /// </summary>
        [JsonProperty("pause_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pause_requested")]
#endif
        public bool? PauseRequested { get; set; }
    }
}

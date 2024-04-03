// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRiskControlsChargesOptions : INestedOptions
    {
        /// <summary>
        /// To request to pause a risk control, pass <c>true</c>. To request to unpause a risk
        /// control, pass <c>false</c>. There can be a delay before the risk control is paused or
        /// unpaused.
        /// </summary>
        [JsonProperty("pause_requested")]
        public bool? PauseRequested { get; set; }
    }
}

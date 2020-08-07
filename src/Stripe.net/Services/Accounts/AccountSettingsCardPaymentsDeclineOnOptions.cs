namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardPaymentsDeclineOnOptions : INestedOptions
    {
        /// <summary>
        /// Whether Stripe automatically declines charges with an incorrect ZIP or postal code. This
        /// setting only applies when a ZIP or postal code is provided and they fail bank
        /// verification.
        /// </summary>
        [JsonProperty("avs_failure")]
        public bool? AvsFailure { get; set; }

        /// <summary>
        /// Whether Stripe automatically declines charges with an incorrect CVC. This setting only
        /// applies when a CVC is provided and it fails bank verification.
        /// </summary>
        [JsonProperty("cvc_failure")]
        public bool? CvcFailure { get; set; }
    }
}

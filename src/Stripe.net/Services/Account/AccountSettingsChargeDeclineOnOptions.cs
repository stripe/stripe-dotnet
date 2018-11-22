namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsChargeDeclineOnOptions : INestedOptions
    {
        [JsonProperty("avs_failure")]
        public bool? AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
        public bool? CvcFailure { get; set; }
    }
}

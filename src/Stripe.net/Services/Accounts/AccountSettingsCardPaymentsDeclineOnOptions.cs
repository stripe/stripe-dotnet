namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardPaymentsDeclineOnOptions : INestedOptions
    {
        [JsonProperty("avs_failure")]
        public bool? AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
        public bool? CvcFailure { get; set; }
    }
}

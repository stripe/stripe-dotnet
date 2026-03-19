namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class AccountSettingsDeclineOn : StripeEntity<AccountSettingsDeclineOn>
    {
        [JsonProperty("avs_failure")]
        [STJS.JsonPropertyName("avs_failure")]
        public bool AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
        [STJS.JsonPropertyName("cvc_failure")]
        public bool CvcFailure { get; set; }
    }
}

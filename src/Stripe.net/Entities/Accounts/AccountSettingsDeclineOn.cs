namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsDeclineOn : StripeEntity<AccountSettingsDeclineOn>
    {
        [JsonProperty("avs_failure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("avs_failure")]
#endif
        public bool AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_failure")]
#endif
        public bool CvcFailure { get; set; }
    }
}

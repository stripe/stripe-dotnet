// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRiskControls : StripeEntity<AccountRiskControls>
    {
        [JsonProperty("charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charges")]
#endif
        public AccountRiskControlsCharges Charges { get; set; }

        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountRiskControlsPayouts Payouts { get; set; }
    }
}

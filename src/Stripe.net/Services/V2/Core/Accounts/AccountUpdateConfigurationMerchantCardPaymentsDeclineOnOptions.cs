// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationMerchantCardPaymentsDeclineOnOptions : INestedOptions
    {
        /// <summary>
        /// Whether Stripe automatically declines charges with an incorrect ZIP or postal code. This
        /// setting only applies when a ZIP or postal code is provided and they fail bank
        /// verification.
        /// </summary>
        [JsonProperty("avs_failure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("avs_failure")]
#endif
        public bool? AvsFailure { get; set; }

        /// <summary>
        /// Whether Stripe automatically declines charges with an incorrect CVC. This setting only
        /// applies when a CVC is provided and it fails bank verification.
        /// </summary>
        [JsonProperty("cvc_failure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_failure")]
#endif
        public bool? CvcFailure { get; set; }
    }
}

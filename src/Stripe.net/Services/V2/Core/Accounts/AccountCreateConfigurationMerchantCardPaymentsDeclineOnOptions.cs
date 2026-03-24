// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantCardPaymentsDeclineOnOptions : INestedOptions
    {
        /// <summary>
        /// Whether Stripe automatically declines charges with an incorrect ZIP or postal code. This
        /// setting only applies when a ZIP or postal code is provided and they fail bank
        /// verification.
        /// </summary>
        [JsonProperty("avs_failure")]
        [STJS.JsonPropertyName("avs_failure")]
        public bool? AvsFailure { get; set; }

        /// <summary>
        /// Whether Stripe automatically declines charges with an incorrect CVC. This setting only
        /// applies when a CVC is provided and it fails bank verification.
        /// </summary>
        [JsonProperty("cvc_failure")]
        [STJS.JsonPropertyName("cvc_failure")]
        public bool? CvcFailure { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantKonbiniPaymentsSupportHours : StripeEntity<AccountConfigurationMerchantKonbiniPaymentsSupportHours>
    {
        /// <summary>
        /// Support hours end time (JST time of day) for in <c>HH:MM</c> format.
        /// </summary>
        [JsonProperty("end_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_time")]
#endif
        public string EndTime { get; set; }

        /// <summary>
        /// Support hours start time (JST time of day) for in <c>HH:MM</c> format.
        /// </summary>
        [JsonProperty("start_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_time")]
#endif
        public string StartTime { get; set; }
    }
}

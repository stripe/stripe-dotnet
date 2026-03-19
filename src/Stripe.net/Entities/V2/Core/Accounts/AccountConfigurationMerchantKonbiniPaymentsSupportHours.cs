// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantKonbiniPaymentsSupportHours : StripeEntity<AccountConfigurationMerchantKonbiniPaymentsSupportHours>
    {
        /// <summary>
        /// Support hours end time (JST time of day) for in <c>HH:MM</c> format.
        /// </summary>
        [JsonProperty("end_time")]
        [STJS.JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// Support hours start time (JST time of day) for in <c>HH:MM</c> format.
        /// </summary>
        [JsonProperty("start_time")]
        [STJS.JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}

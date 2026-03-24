// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsPaypayPaymentsSite : StripeEntity<AccountSettingsPaypayPaymentsSite>
    {
        [JsonProperty("accessible")]
        [STJS.JsonPropertyName("accessible")]
        public AccountSettingsPaypayPaymentsSiteAccessible Accessible { get; set; }

        [JsonProperty("in_development")]
        [STJS.JsonPropertyName("in_development")]
        public AccountSettingsPaypayPaymentsSiteInDevelopment InDevelopment { get; set; }

        [JsonProperty("restricted")]
        [STJS.JsonPropertyName("restricted")]
        public AccountSettingsPaypayPaymentsSiteRestricted Restricted { get; set; }

        /// <summary>
        /// The status of your business's website.
        /// One of: <c>accessible</c>, <c>in_development</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

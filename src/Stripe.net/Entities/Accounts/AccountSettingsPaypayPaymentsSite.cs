// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaypayPaymentsSite : StripeEntity<AccountSettingsPaypayPaymentsSite>
    {
        [JsonProperty("accessible")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accessible")]
#endif
        public AccountSettingsPaypayPaymentsSiteAccessible Accessible { get; set; }

        [JsonProperty("in_development")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("in_development")]
#endif
        public AccountSettingsPaypayPaymentsSiteInDevelopment InDevelopment { get; set; }

        [JsonProperty("restricted")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restricted")]
#endif
        public AccountSettingsPaypayPaymentsSiteRestricted Restricted { get; set; }

        /// <summary>
        /// The status of your business's website.
        /// One of: <c>accessible</c>, <c>in_development</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}

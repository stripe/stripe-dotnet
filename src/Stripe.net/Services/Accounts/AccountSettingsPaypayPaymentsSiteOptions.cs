// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaypayPaymentsSiteOptions : INestedOptions
    {
        /// <summary>
        /// Additional information about your business's website.
        /// </summary>
        [JsonProperty("accessible")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accessible")]
#endif
        public AccountSettingsPaypayPaymentsSiteAccessibleOptions Accessible { get; set; }

        /// <summary>
        /// Additional information about your business's website.
        /// </summary>
        [JsonProperty("in_development")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("in_development")]
#endif
        public AccountSettingsPaypayPaymentsSiteInDevelopmentOptions InDevelopment { get; set; }

        /// <summary>
        /// Additional information about your business's website.
        /// </summary>
        [JsonProperty("restricted")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restricted")]
#endif
        public AccountSettingsPaypayPaymentsSiteRestrictedOptions Restricted { get; set; }

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

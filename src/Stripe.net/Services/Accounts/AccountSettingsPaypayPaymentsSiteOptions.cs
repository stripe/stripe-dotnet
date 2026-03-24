// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsPaypayPaymentsSiteOptions : INestedOptions
    {
        /// <summary>
        /// Additional information about your business's website.
        /// </summary>
        [JsonProperty("accessible")]
        [STJS.JsonPropertyName("accessible")]
        public AccountSettingsPaypayPaymentsSiteAccessibleOptions Accessible { get; set; }

        /// <summary>
        /// Additional information about your business's website.
        /// </summary>
        [JsonProperty("in_development")]
        [STJS.JsonPropertyName("in_development")]
        public AccountSettingsPaypayPaymentsSiteInDevelopmentOptions InDevelopment { get; set; }

        /// <summary>
        /// Additional information about your business's website.
        /// </summary>
        [JsonProperty("restricted")]
        [STJS.JsonPropertyName("restricted")]
        public AccountSettingsPaypayPaymentsSiteRestrictedOptions Restricted { get; set; }

        /// <summary>
        /// The status of your business's website.
        /// One of: <c>accessible</c>, <c>in_development</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

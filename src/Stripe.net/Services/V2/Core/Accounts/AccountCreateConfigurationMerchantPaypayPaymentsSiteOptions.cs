// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantPaypayPaymentsSiteOptions : INestedOptions
    {
        /// <summary>
        /// Additional information about the business's website when it's accessible.
        /// </summary>
        [JsonProperty("accessible")]
        [STJS.JsonPropertyName("accessible")]
        public AccountCreateConfigurationMerchantPaypayPaymentsSiteAccessibleOptions Accessible { get; set; }

        /// <summary>
        /// Additional information about the business's website when it's in development.
        /// </summary>
        [JsonProperty("in_development")]
        [STJS.JsonPropertyName("in_development")]
        public AccountCreateConfigurationMerchantPaypayPaymentsSiteInDevelopmentOptions InDevelopment { get; set; }

        /// <summary>
        /// Additional information about the business's website when it has restricted access.
        /// </summary>
        [JsonProperty("restricted")]
        [STJS.JsonPropertyName("restricted")]
        public AccountCreateConfigurationMerchantPaypayPaymentsSiteRestrictedOptions Restricted { get; set; }

        /// <summary>
        /// The status of the business's website.
        /// One of: <c>accessible</c>, <c>in_development</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

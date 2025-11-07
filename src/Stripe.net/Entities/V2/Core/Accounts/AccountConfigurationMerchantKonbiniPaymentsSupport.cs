// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantKonbiniPaymentsSupport : StripeEntity<AccountConfigurationMerchantKonbiniPaymentsSupport>
    {
        /// <summary>
        /// Support email address for Konbini payments.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// Support hours for Konbini payments.
        /// </summary>
        [JsonProperty("hours")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hours")]
#endif
        public AccountConfigurationMerchantKonbiniPaymentsSupportHours Hours { get; set; }

        /// <summary>
        /// Support phone number for Konbini payments.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }
    }
}

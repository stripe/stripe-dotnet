// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantBacsDebitPayments : StripeEntity<AccountConfigurationMerchantBacsDebitPayments>
    {
        /// <summary>
        /// Display name for Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Service User Number (SUN) for Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("service_user_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_user_number")]
#endif
        public string ServiceUserNumber { get; set; }
    }
}

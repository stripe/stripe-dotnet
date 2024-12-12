// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsBankBcaOnboarding : StripeEntity<AccountSettingsBankBcaOnboarding>
    {
        /// <summary>
        /// Bank BCA business account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Bank BCA business account number.
        /// </summary>
        [JsonProperty("business_account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_account_number")]
#endif
        public string BusinessAccountNumber { get; set; }
    }
}

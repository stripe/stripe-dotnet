// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsBankBcaOnboardingOptions : INestedOptions
    {
        /// <summary>
        /// Bank BCA business account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Bank BCA business account number.
        /// </summary>
        [JsonProperty("business_account_number")]
        [STJS.JsonPropertyName("business_account_number")]
        public string BusinessAccountNumber { get; set; }
    }
}

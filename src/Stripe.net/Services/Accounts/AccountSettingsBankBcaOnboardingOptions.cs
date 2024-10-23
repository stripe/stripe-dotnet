// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBankBcaOnboardingOptions : INestedOptions
    {
        /// <summary>
        /// Bank BCA business account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Bank BCA business account number.
        /// </summary>
        [JsonProperty("business_account_number")]
        public string BusinessAccountNumber { get; set; }
    }
}

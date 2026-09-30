// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCreateStorageOptions : INestedOptions
    {
        /// <summary>
        /// Array of eligibility objects, segmented by bank name and deposit insurance scheme.
        /// </summary>
        [JsonProperty("deposit_insurance_eligibility")]
        [STJS.JsonPropertyName("deposit_insurance_eligibility")]
        public List<FinancialAccountCreateStorageDepositInsuranceEligibilityOptions> DepositInsuranceEligibility { get; set; }

        /// <summary>
        /// The currencies that this FinancialAccount can hold.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }
    }
}

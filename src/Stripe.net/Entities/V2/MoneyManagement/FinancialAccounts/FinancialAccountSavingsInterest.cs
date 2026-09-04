// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountSavingsInterest : StripeEntity<FinancialAccountSavingsInterest>
    {
        /// <summary>
        /// The interest rate applied to this savings FinancialAccount.
        /// </summary>
        [JsonProperty("rate")]
        [STJS.JsonPropertyName("rate")]
        public FinancialAccountSavingsInterestRate Rate { get; set; }
    }
}

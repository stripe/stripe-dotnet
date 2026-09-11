// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutPayoutMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Additional options for a Financial Account payout method. Only valid when payout_method
        /// is a Financial Account ID.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public PayoutPayoutMethodOptionsFinancialAccountOptions FinancialAccount { get; set; }
    }
}

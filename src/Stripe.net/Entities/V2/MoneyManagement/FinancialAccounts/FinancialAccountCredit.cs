// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountCredit : StripeEntity<FinancialAccountCredit>
    {
        /// <summary>
        /// Details about how this credit FinancialAccount is funded.
        /// </summary>
        [JsonProperty("funded_by")]
        [STJS.JsonPropertyName("funded_by")]
        public FinancialAccountCreditFundedBy FundedBy { get; set; }

        /// <summary>
        /// The currencies supported by this credit FinancialAccount.
        /// </summary>
        [JsonProperty("supported_currencies")]
        [STJS.JsonPropertyName("supported_currencies")]
        public List<string> SupportedCurrencies { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountMultiprocessorSettlement : StripeEntity<FinancialAccountMultiprocessorSettlement>
    {
        /// <summary>
        /// Settlement currencies enabled for this FinancialAccount.
        /// </summary>
        [JsonProperty("settlement_currencies")]
        [STJS.JsonPropertyName("settlement_currencies")]
        public List<string> SettlementCurrencies { get; set; }
    }
}

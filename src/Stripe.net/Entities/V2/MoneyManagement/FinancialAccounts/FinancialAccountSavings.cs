// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountSavings : StripeEntity<FinancialAccountSavings>
    {
        /// <summary>
        /// The currencies that this savings FinancialAccount can hold.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }

        /// <summary>
        /// Interest details for this savings FinancialAccount. Populated by the server.
        /// </summary>
        [JsonProperty("interest")]
        [STJS.JsonPropertyName("interest")]
        public FinancialAccountSavingsInterest Interest { get; set; }
    }
}

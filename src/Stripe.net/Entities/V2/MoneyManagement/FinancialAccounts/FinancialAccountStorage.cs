// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountStorage : StripeEntity<FinancialAccountStorage>
    {
        /// <summary>
        /// The currencies that this FinancialAccount can hold.
        /// </summary>
        [JsonProperty("holds_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("holds_currencies")]
#endif
        public List<string> HoldsCurrencies { get; set; }
    }
}

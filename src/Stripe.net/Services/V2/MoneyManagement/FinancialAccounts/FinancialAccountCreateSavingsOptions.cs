// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCreateSavingsOptions : INestedOptions
    {
        /// <summary>
        /// The currencies that this savings FinancialAccount can hold. Three-letter ISO currency
        /// code, in lowercase.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }
    }
}

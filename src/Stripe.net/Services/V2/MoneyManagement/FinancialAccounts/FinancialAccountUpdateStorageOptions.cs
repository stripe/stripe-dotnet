// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountUpdateStorageOptions : INestedOptions
    {
        /// <summary>
        /// The currencies that this storage FinancialAccount can hold a balance in. Three-letter
        /// ISO currency code, in lowercase. Adding currencies requires the corresponding
        /// holds_currencies storer capabilities to be enabled. Removing currencies is not supported
        /// as of March 2026.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }
    }
}

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
        /// The currencies that the storage FinancialAccount can hold a balance in. Three-letter ISO
        /// currency code, in lowercase. Must be a subset of the currencies requested in
        /// <c>configuration.storer.features.holds_currencies</c> of the v2/accounts API.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityBusinessDetailsAnnualRevenueOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative integer representing the amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The close-out date of the preceding fiscal year in ISO 8601 format. E.g. 2023-12-31 for
        /// the 31st of December, 2023.
        /// </summary>
        [JsonProperty("fiscal_year_end")]
        [STJS.JsonPropertyName("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }
    }
}

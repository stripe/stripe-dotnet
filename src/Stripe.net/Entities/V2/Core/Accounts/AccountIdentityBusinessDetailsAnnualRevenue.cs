// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityBusinessDetailsAnnualRevenue : StripeEntity<AccountIdentityBusinessDetailsAnnualRevenue>
    {
        /// <summary>
        /// A non-negative integer representing the amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The close-out date of the preceding fiscal year in ISO 8601 format. E.g. 2023-12-31 for
        /// the 31st of December, 2023.
        /// </summary>
        [JsonProperty("fiscal_year_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fiscal_year_end")]
#endif
        public string FiscalYearEnd { get; set; }
    }
}

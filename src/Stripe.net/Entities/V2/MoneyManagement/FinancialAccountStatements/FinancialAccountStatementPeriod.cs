// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatementPeriod : StripeEntity<FinancialAccountStatementPeriod>
    {
        /// <summary>
        /// The end of the statement period (exclusive), as a UTC-aligned ISO 8601 date (e.g.,
        /// "2025-02-01"). For example, a January statement has end_date "2025-02-01", meaning all
        /// transactions up to but not including February 1st UTC are included.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// The start of the statement period (inclusive), as a UTC-aligned ISO 8601 date (e.g.,
        /// "2025-01-01").
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}

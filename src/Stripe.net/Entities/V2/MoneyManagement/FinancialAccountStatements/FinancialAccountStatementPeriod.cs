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
        /// The end of the statement period (inclusive), as a UTC-aligned ISO 8601 date (e.g.,
        /// "2026-05-31"). For example, a May 2026 statement has end_date "2026-05-31", meaning all
        /// transactions up to and including May 31st UTC are included.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// The start of the statement period (inclusive), as a UTC-aligned ISO 8601 date (e.g.,
        /// "2026-05-01").
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}

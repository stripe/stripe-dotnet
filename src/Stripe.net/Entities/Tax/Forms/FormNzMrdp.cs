// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FormNzMrdp : StripeEntity<FormNzMrdp>
    {
        /// <summary>
        /// End date of the period represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_period_end_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reporting_period_end_date")]
#endif
        public string ReportingPeriodEndDate { get; set; }

        /// <summary>
        /// Start date of the period represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_period_start_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reporting_period_start_date")]
#endif
        public string ReportingPeriodStartDate { get; set; }
    }
}

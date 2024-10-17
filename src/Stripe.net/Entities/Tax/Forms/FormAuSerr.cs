// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class FormAuSerr : StripeEntity<FormAuSerr>
    {
        /// <summary>
        /// End date of the period represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_period_end_date")]
        public string ReportingPeriodEndDate { get; set; }

        /// <summary>
        /// Start date of the period represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_period_start_date")]
        public string ReportingPeriodStartDate { get; set; }
    }
}

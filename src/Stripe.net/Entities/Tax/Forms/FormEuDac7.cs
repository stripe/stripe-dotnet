// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormEuDac7 : StripeEntity<FormEuDac7>
    {
        /// <summary>
        /// End date of the period represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_period_end_date")]
        [STJS.JsonPropertyName("reporting_period_end_date")]
        public string ReportingPeriodEndDate { get; set; }

        /// <summary>
        /// Start date of the period represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_period_start_date")]
        [STJS.JsonPropertyName("reporting_period_start_date")]
        public string ReportingPeriodStartDate { get; set; }
    }
}

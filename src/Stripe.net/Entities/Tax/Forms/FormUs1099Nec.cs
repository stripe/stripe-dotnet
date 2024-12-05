// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class FormUs1099Nec : StripeEntity<FormUs1099Nec>
    {
        /// <summary>
        /// Year represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_year")]
        public long ReportingYear { get; set; }
    }
}

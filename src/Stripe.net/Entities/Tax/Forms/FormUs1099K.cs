// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormUs1099K : StripeEntity<FormUs1099K>
    {
        /// <summary>
        /// Year represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_year")]
        [STJS.JsonPropertyName("reporting_year")]
        public long ReportingYear { get; set; }
    }
}

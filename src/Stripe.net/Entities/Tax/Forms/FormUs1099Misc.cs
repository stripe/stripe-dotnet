// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FormUs1099Misc : StripeEntity<FormUs1099Misc>
    {
        /// <summary>
        /// Year represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reporting_year")]
#endif
        public long ReportingYear { get; set; }
    }
}

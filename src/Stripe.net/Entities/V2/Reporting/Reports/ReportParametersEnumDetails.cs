// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportParametersEnumDetails : StripeEntity<ReportParametersEnumDetails>
    {
        /// <summary>
        /// Allowed values of the enum.
        /// </summary>
        [JsonProperty("allowed_values")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allowed_values")]
#endif
        public List<string> AllowedValues { get; set; }
    }
}

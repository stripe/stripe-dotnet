// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportParametersArrayDetailsEnumDetails : StripeEntity<ReportParametersArrayDetailsEnumDetails>
    {
        /// <summary>
        /// Allowed values of the enum.
        /// </summary>
        [JsonProperty("allowed_values")]
        [STJS.JsonPropertyName("allowed_values")]
        public List<string> AllowedValues { get; set; }
    }
}

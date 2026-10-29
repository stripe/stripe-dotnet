// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunResultInlineRow : StripeEntity<ReportRunResultInlineRow>
    {
        /// <summary>
        /// The column data in this row, keyed by column name.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public Dictionary<string, object> Data { get; set; }
    }
}

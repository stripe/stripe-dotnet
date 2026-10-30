// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunResultOptions : StripeEntity<ReportRunResultOptions>
    {
        /// <summary>
        /// The compression applied to the generated result file. Defaults to <c>none</c>. This
        /// applies only to downloadable file results.
        /// One of: <c>none</c>, or <c>zip</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("compression")]
        [STJS.JsonPropertyName("compression")]
        public string Compression { get; set; }
    }
}

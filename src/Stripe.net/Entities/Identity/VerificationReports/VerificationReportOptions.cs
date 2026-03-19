// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportOptions : StripeEntity<VerificationReportOptions>
    {
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public VerificationReportOptionsDocument Document { get; set; }

        [JsonProperty("id_number")]
        [STJS.JsonPropertyName("id_number")]
        public VerificationReportOptionsIdNumber IdNumber { get; set; }
    }
}

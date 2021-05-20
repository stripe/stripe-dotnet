// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationReportListOptions : ListOptionsWithCreated
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verification_session")]
        public string VerificationSession { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationReportOptions : StripeEntity<VerificationReportOptions>
    {
        [JsonProperty("document")]
        public VerificationReportOptionsDocument Document { get; set; }

        [JsonProperty("id_number")]
        public VerificationReportOptionsIdNumber IdNumber { get; set; }
    }
}

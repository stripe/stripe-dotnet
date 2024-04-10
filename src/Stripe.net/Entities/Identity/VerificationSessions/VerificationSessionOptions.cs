// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionOptions : StripeEntity<VerificationSessionOptions>
    {
        [JsonProperty("document")]
        public VerificationSessionOptionsDocument Document { get; set; }

        [JsonProperty("email")]
        public VerificationSessionOptionsEmail Email { get; set; }

        [JsonProperty("id_number")]
        public VerificationSessionOptionsIdNumber IdNumber { get; set; }

        [JsonProperty("phone")]
        public VerificationSessionOptionsPhone Phone { get; set; }
    }
}

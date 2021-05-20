// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

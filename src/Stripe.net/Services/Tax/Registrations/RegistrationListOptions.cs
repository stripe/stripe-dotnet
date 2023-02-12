// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationListOptions : ListOptions
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

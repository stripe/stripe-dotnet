// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkListOptions : ListOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }
    }
}

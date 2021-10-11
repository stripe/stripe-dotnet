// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerListPaymentMethodsOptions : ListOptions
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

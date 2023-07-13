// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationListOptions : ListOptions
    {
        [JsonProperty("application")]
        public string Application { get; set; }
    }
}

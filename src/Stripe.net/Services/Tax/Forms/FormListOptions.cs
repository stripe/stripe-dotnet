// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class FormListOptions : ListOptions
    {
        [JsonProperty("payee")]
        public FormPayeeOptions Payee { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

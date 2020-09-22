// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplicationFeeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}

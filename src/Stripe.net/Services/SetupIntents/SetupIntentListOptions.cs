// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentListOptions : ListOptionsWithCreated
    {
        [JsonProperty("attach_to_self")]
        public bool? AttachToSelf { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }
    }
}

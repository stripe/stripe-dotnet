namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}

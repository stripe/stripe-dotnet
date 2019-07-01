namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }
    }
}

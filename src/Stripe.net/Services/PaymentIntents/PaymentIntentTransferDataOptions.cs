namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        // This is only available on creation and not update
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}

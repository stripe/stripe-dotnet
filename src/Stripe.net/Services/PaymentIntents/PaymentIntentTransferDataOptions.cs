namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        [JsonProperty("transfer_data[amount]")]
        public int? Amount { get; set; }

        // This is only available on creation and not update
        [JsonProperty("transfer_data[destination]")]
        public string Destination { get; set; }
    }
}

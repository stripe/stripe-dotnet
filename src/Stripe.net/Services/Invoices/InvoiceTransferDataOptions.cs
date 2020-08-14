namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceTransferDataOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}

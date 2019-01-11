namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceTransferDataOptions : INestedOptions
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}

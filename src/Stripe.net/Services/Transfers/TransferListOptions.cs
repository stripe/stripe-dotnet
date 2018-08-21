namespace Stripe
{
    using Newtonsoft.Json;

    public class TransferListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
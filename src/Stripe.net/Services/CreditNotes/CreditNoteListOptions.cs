namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNoteListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }
    }
}

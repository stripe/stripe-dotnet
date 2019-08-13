namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }
    }
}

namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }
    }
}

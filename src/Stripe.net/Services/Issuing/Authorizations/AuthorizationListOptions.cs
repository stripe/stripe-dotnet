namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationListOptions : ListOptionsWithCreated
    {
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

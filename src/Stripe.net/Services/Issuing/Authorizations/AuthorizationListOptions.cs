namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationListOptions : ListOptionsWithCreated
    {
        [JsonProperty("cardholder")]
        public string CardholderId { get; set; }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

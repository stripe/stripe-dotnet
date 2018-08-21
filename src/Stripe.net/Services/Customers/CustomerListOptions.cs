namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
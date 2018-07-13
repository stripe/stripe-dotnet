namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeCustomerListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
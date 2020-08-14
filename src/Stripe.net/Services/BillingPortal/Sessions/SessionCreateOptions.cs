namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionCreateOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}

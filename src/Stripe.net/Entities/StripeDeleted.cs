namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeDeleted : StripeEntityWithId
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}
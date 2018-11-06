namespace Stripe
{
    using Newtonsoft.Json;

    public abstract class StripeEntity : IStripeEntity
    {
        [JsonIgnore]
        public StripeResponse StripeResponse { get; set; }
    }
}

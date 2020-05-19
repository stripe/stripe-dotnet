namespace Stripe.Sigma
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ScheduledQueryRunError : StripeEntity<ScheduledQueryRunError>
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

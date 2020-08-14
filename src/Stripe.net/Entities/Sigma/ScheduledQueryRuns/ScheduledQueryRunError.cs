namespace Stripe.Sigma
{
    using Newtonsoft.Json;

    public class ScheduledQueryRunError : StripeEntity<ScheduledQueryRunError>
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

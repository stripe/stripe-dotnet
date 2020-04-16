namespace Stripe.Sigma
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ScheduledQueryRunError : StripeEntity<ScheduledQueryRunError>
    {
        /// <summary>
        /// Information about the run failure.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

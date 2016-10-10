using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// The optional arguments you can pass. <see href="https://stripe.com/docs/api#list_disputes">Stripe Documentation</see>
    /// </summary>
    public class StripeDisputeListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}
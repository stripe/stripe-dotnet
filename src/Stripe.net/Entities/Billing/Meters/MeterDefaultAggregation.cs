// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterDefaultAggregation : StripeEntity<MeterDefaultAggregation>
    {
        /// <summary>
        /// Specifies how events are aggregated.
        /// One of: <c>count</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("formula")]
        public string Formula { get; set; }
    }
}

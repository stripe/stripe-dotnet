// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseItemTrialPaid : StripeEntity<SubscriptionSchedulePhaseItemTrialPaid>, IHasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemMetronomeCommitCommitAccessScheduleOptions : INestedOptions
    {
        /// <summary>
        /// The fixed price the buyer pays, in minor currency units.
        /// </summary>
        [JsonProperty("price_amount")]
        [STJS.JsonPropertyName("price_amount")]
        public long? PriceAmount { get; set; }

        /// <summary>
        /// When and how many credits become available.
        /// </summary>
        [JsonProperty("schedule_items")]
        [STJS.JsonPropertyName("schedule_items")]
        public List<SessionItemMetronomeCommitCommitAccessScheduleScheduleItemOptions> ScheduleItems { get; set; }
    }
}

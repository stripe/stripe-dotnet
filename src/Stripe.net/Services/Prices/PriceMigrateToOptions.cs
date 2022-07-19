// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceMigrateToOptions : INestedOptions
    {
        /// <summary>
        /// The behavior controlling the point in the subscription lifecycle after which to migrate
        /// the price. Currently must be <c>at_cycle_end</c>.
        /// </summary>
        [JsonProperty("behavior")]
        public string Behavior { get; set; }

        /// <summary>
        /// The time after which subscriptions should start using the new price.
        /// </summary>
        [JsonProperty("effective_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EffectiveAfter { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
    }
}

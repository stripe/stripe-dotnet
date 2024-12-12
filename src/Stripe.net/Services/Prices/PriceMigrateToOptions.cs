// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceMigrateToOptions : INestedOptions
    {
        /// <summary>
        /// The behavior controlling the point in the subscription lifecycle after which to migrate
        /// the price. Currently must be <c>at_cycle_end</c>.
        /// </summary>
        [JsonProperty("behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("behavior")]
#endif
        public string Behavior { get; set; }

        /// <summary>
        /// The time after which subscriptions should start using the new price.
        /// </summary>
        [JsonProperty("effective_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? EffectiveAfter { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }
    }
}

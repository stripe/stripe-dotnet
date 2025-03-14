// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceMigrateTo : StripeEntity<PriceMigrateTo>
    {
        /// <summary>
        /// The behavior controlling at what point in the subscription lifecycle to migrate the
        /// price.
        /// </summary>
        [JsonProperty("behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("behavior")]
#endif
        public string Behavior { get; set; }

        /// <summary>
        /// The unix timestamp after at which subscriptions will start to migrate to the new price.
        /// </summary>
        [JsonProperty("effective_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime EffectiveAfter { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The id of the price being migrated to.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }
    }
}

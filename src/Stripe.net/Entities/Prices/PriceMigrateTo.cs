// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceMigrateTo : StripeEntity<PriceMigrateTo>
    {
        /// <summary>
        /// The behavior controlling at what point in the subscription lifecycle to migrate the
        /// price.
        /// </summary>
        [JsonProperty("behavior")]
        public string Behavior { get; set; }

        /// <summary>
        /// The unix timestamp after at which subscriptions will start to migrate to the new price.
        /// </summary>
        [JsonProperty("effective_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EffectiveAfter { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The id of the price being migrated to.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionLastPriceMigrationErrorFailedTransition : StripeEntity<SubscriptionLastPriceMigrationErrorFailedTransition>
    {
        /// <summary>
        /// The original price to be migrated.
        /// </summary>
        [JsonProperty("source_price")]
        [STJS.JsonPropertyName("source_price")]
        public string SourcePrice { get; set; }

        /// <summary>
        /// The intended resulting price of the migration.
        /// </summary>
        [JsonProperty("target_price")]
        [STJS.JsonPropertyName("target_price")]
        public string TargetPrice { get; set; }
    }
}

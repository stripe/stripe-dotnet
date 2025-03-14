// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleLastPriceMigrationErrorFailedTransition : StripeEntity<SubscriptionScheduleLastPriceMigrationErrorFailedTransition>
    {
        /// <summary>
        /// The original price to be migrated.
        /// </summary>
        [JsonProperty("source_price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_price")]
#endif
        public string SourcePrice { get; set; }

        /// <summary>
        /// The intended resulting price of the migration.
        /// </summary>
        [JsonProperty("target_price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("target_price")]
#endif
        public string TargetPrice { get; set; }
    }
}

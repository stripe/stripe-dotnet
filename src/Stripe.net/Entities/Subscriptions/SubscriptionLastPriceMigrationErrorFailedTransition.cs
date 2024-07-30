// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionLastPriceMigrationErrorFailedTransition : StripeEntity<SubscriptionLastPriceMigrationErrorFailedTransition>
    {
        /// <summary>
        /// The original price to be migrated.
        /// </summary>
        [JsonProperty("source_price")]
        public string SourcePrice { get; set; }

        /// <summary>
        /// The intended resulting price of the migration.
        /// </summary>
        [JsonProperty("target_price")]
        public string TargetPrice { get; set; }
    }
}

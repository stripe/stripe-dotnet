// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertSpendThresholdConfigOptions : INestedOptions
    {
        /// <summary>
        /// Whether the spend should be aggregated across items in a subscription or whether each
        /// subscription item is considered alone.
        /// One of: <c>subscription</c>, or <c>subscription_item</c>.
        /// </summary>
        [JsonProperty("aggregation")]
        public string Aggregation { get; set; }

        /// <summary>
        /// Currency for which this spend alert is configured. This alert will only trigger for
        /// subscriptions matching this currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Defines at which value the alert will fire.
        /// </summary>
        [JsonProperty("gte")]
        public long? Gte { get; set; }

        /// <summary>
        /// Whether the alert should only fire only once, or once per billing cycle.
        /// </summary>
        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }
    }
}

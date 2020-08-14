namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderStatusTransitionsOptions : INestedOptions
    {
        /// <summary>
        /// Date this order was canceled.
        /// </summary>
        [JsonProperty("canceled")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Canceled { get; set; }

        /// <summary>
        /// Date this order was fulfilled.
        /// </summary>
        [JsonProperty("fulfilled")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Fulfilled { get; set; }

        /// <summary>
        /// Date this order was paid.
        /// </summary>
        [JsonProperty("paid")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Paid { get; set; }

        /// <summary>
        /// Date this order was returned.
        /// </summary>
        [JsonProperty("returned")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Returned { get; set; }
    }
}

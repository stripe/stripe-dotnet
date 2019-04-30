namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderStatusTransitionsOptions : INestedOptions
    {
        /// <summary>
        /// A filter on the list based on the object <c>canceled</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("canceled")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Canceled { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>fulfilled</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("fulfilled")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Fulfilled { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>paid</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("paid")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Paid { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>returned</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("returned")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Returned { get; set; }
    }
}

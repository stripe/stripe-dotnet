using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeStatusTransitions : StripeEntity
    {
        /// <summary>
        /// Gets or sets the date of cancellation.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("canceled")]
        public DateTime? Canceled { get; set; }

        /// <summary>
        /// Gets or sets the date of fulfillment.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("fulfiled")]
        public DateTime? Fulfiled { get; set; }

        /// <summary>
        /// Gets or sets date of payment.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("paid")]
        public DateTime? Paid { get; set; }

        /// <summary>
        /// Gets or sets date of return.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("returned")]
        public DateTime? Returned { get; set; }
    }
}

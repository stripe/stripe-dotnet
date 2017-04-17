using System;
using System.Collections.Generic;
using Stripe.Infrastructure;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderReturn : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object => "order_return";


        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the line item.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The items included in this order return.
        /// </summary>
        [JsonProperty("items")]
        public List<StripeOrderItem> Items { get; set; }

        /// <summary>
        /// Flag indicating whether the object exists in live mode or test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        /// <summary>
        /// The order that this return includes items from.
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// The ID of the refund issued for this return.
        /// </summary>
        [JsonProperty("refund")]
        public string Refund { get; set; }
    }
}

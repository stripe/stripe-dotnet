using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeReturn : StripeEntityWithId
    {
        /// <summary>
        /// Gets or sets the object Type. value is "order_return"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Gets or sets a a positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the returned line item.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the order creation date and time.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets a 3-letter ISO code representing the currency in which the order was made.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets a list of items constituting the order.
        /// </summary>
        [JsonProperty("items")]
        public List<StripeOrderItem> StripeOrderItems { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the return is in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        #region Expandable Order
        /// <summary>
        /// Gets or sets the order that this return includes items from
        /// Expandable
        /// </summary>
        public string OrderId { get; set; }

        [JsonIgnore]
        public StripeOrder Order { get; set; }

        [JsonProperty("order")]
        internal object InternalOrder
        {
            set
            {
                ExpandableProperty<StripeOrder>.Map(value, s => OrderId = s, o => Order = o);
            }
        }
        #endregion



        #region Expandable Refund
        /// <summary>
        /// Gets or sets the ID of the refund issued for this return.
        /// Expandable
        /// </summary>
        public string RefundId { get; set; }

        [JsonIgnore]
        public StripeRefund Refund { get; set; }

        [JsonProperty("refund")]
        internal object InternalRefund
        {
            set
            {
                ExpandableProperty<StripeRefund>.Map(value, s => RefundId = s, o => Refund = o);
            }
        }
        #endregion
    }
}

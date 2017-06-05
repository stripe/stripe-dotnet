using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeReturn : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the returned line item.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// 3-letter ISO code representing the currency of the return.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The items included in this order return.
        /// </summary>
        [JsonProperty("items")]
        public List<StripeOrderItem> OrderItems { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        #region Expandable Order
        /// <summary>
        /// <para>The order that this return includes items from.</para>
        /// <para>Expandable</para>
        /// </summary>
        public string OrderId { get; set; }

        [JsonIgnore]
        public StripeOrder Order { get; set; }

        [JsonProperty("order")]
        internal object InternalOrder
        {
            set
            {
                StringOrObject<StripeOrder>.Map(value, s => OrderId = s, o => Order = o);
            }
        }
        #endregion

        #region Expandable Refund
        /// <summary>
        /// <para>The ID of the refund issued for this return.</para>
        /// <para>Expandable</para>
        /// </summary>
        public string RefundId { get; set; }

        [JsonIgnore]
        public StripeRefund Refund { get; set; }

        [JsonProperty("refund")]
        internal object InternalRefund
        {
            set
            {
                StringOrObject<StripeRefund>.Map(value, s => RefundId = s, o => Refund = o);
            }
        }
        #endregion
    }
}

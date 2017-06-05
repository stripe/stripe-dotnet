using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeDiscount : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("coupon")]
        public StripeCoupon StripeCoupon { get; set; }

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
        #endregion

        #region Expandable Subscription
        public string SubscriptionId { get; set; }

        [JsonIgnore]
        public StripeSubscription Subscription { get; set; }

        [JsonProperty("subscription")]
        internal object InternalSubscription
        {
            set
            {
                StringOrObject<StripeSubscription>.Map(value, s => SubscriptionId = s, o => Subscription = o);
            }
        }
        #endregion

        [JsonProperty("start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Start { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? End { get; set; }
    }
}

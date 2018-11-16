namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Discount : StripeEntity, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("coupon")]
        public Coupon Coupon { get; set; }

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? End { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Start { get; set; }

        #region Expandable Subscription
        public string SubscriptionId { get; set; }

        [JsonIgnore]
        public Subscription Subscription { get; set; }

        [JsonProperty("subscription")]
        internal object InternalSubscription
        {
            set
            {
                StringOrObject<Subscription>.Map(value, s => this.SubscriptionId = s, o => this.Subscription = o);
            }
        }
        #endregion
    }
}

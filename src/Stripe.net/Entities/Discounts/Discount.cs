namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Discount : StripeEntity<Discount>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("coupon")]
        public Coupon Coupon { get; set; }

        #region Expandable Customer
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer.Id;
            set => this.InternalCustomer.Id = value;
        }

        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer.ExpandedObject;
            set => this.InternalCustomer.ExpandedObject = value;
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? End { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Start { get; set; }

        #region Expandable Subscription
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription.Id;
            set => this.InternalSubscription.Id = value;
        }

        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription.ExpandedObject;
            set => this.InternalSubscription.ExpandedObject = value;
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion
    }
}

namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Order : StripeEntity<Order>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_returned")]
        public long? AmountReturned { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external_coupon_code")]
        public string ExternalCouponCode { get; set; }

        [JsonProperty("items")]
        public List<OrderItem> Items { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("returns")]
        public StripeList<OrderReturn> Returns { get; set; }

        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        [JsonProperty("shipping_methods")]
        public List<ShippingMethod> ShippingMethods { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public StatusTransitions StatusTransitions { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Updated { get; set; }

        [JsonProperty("upstream_id")]
        public string UpstreamId { get; set; }
    }
}

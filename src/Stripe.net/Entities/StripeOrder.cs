using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeOrder : StripeEntityWithId
    {
        /// <summary>
        /// v2017-01-27: Gets or sets the object Type. value is "order"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets a positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the order.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets the amount returned
        /// </summary>
        [JsonProperty("amount_returned")]
        public int? AmountReturned { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets the ID of the Connect Application that created the order.
        /// </summary>
        [JsonProperty("application")]
        public string Application { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets the application fee
        /// </summary>
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }


        #region Expandable Charge
        /// <summary>
        /// v2017-01-27: Gets or sets the ID of the payment used to pay for the order. Present if the order status is paid, fulfilled, or refunded.
        /// Expandable
        /// </summary>
        public string ChargeId { get; set; }

        [JsonIgnore]
        public StripeCharge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            set
            {
                ExpandableProperty<StripeCharge>.Map(value, s => ChargeId = s, o => Charge = o);
            }
        }
        #endregion

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


        #region Expandable Customer
        /// <summary>
        /// Gets or sets the customer used for the order.
        /// </summary>
        public string CustomerId { get; set; }

        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                ExpandableProperty<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the email address of the customer placing the order.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets an external coupon code.
        /// </summary>
        [JsonProperty("external_coupon_code")]
        public string ExternalCouponCode { get; set; }

        /// <summary>
        /// Gets or sets a list of items constituting the order.
        /// </summary>
        [JsonProperty("items")]
        public List<StripeOrderItem> StripeOrderItems { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order is in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        /// <summary>
        /// Gets or sets a set of key/value pairs that you can attach to an order object. It can be useful for storing additional information about the order in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the returns associated with this order.
        /// </summary>
        [JsonProperty("returns")]
        public StripeList<StripeReturn> StripeReturns { get; set; }

        /// <summary>
        /// Gets or sets the shipping method that is currently selected for this order, if any. If present, it is equal to one of the ids of shipping methods in the shipping_methods array. At order creation time, if there are multiple shipping methods, Stripe will automatically selected the first method.
        /// </summary>
        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        /// <summary>
        /// Gets or sets the customer shipping address.
        /// </summary>
        [JsonProperty("shipping")]
        public StripeShipping Shipping { get; set; }

        /// <summary>
        /// Gets or sets the shipping methods.
        /// </summary>
        [JsonProperty("shipping_methods")]
        public List<StripeShippingMethod> ShippingMethods { get; set; }

        /// <summary>
        /// Gets or sets the current order status. One of created, paid, canceled, fulfilled, or returned. More detail in the Relay API Overview.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the timestamps at which the order status was updated.
        /// </summary>
        [JsonProperty("status_transitions")]
        public StripeStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Gets or sets the order modification date and time.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the merchant’s order ID if it is different from the Stripe order ID.
        /// </summary>
        [JsonProperty("upstream_id")]
        public string UpstreamId { get; set; }
    }
}

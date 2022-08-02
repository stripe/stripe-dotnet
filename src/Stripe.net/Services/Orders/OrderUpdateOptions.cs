// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Settings for automatic tax calculation for this order.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public OrderAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Billing details for the customer. If a customer is provided, this will be automatically
        /// populated with values from that customer if override values are not provided.
        /// </summary>
        [JsonProperty("billing_details")]
        public OrderBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer associated with this order.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The coupons, promotion codes, and/or discounts to apply to the order. Pass the empty
        /// string <c>""</c> to unset this field.
        /// </summary>
        [JsonProperty("discounts")]
        public List<OrderDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The IP address of the purchaser for this order.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// A list of line items the customer is ordering. Each line item includes information about
        /// the product, the quantity, and the resulting cost.
        /// </summary>
        [JsonProperty("line_items")]
        public List<OrderLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Payment information associated with the order, including payment settings.
        /// </summary>
        [JsonProperty("payment")]
        public OrderPaymentOptions Payment { get; set; }

        /// <summary>
        /// Settings for the customer cost of shipping for this order.
        /// </summary>
        [JsonProperty("shipping_cost")]
        public OrderShippingCostOptions ShippingCost { get; set; }

        /// <summary>
        /// Shipping details for the order.
        /// </summary>
        [JsonProperty("shipping_details")]
        public OrderShippingDetailsOptions ShippingDetails { get; set; }

        /// <summary>
        /// Additional tax details about the purchaser to be used for this order.
        /// </summary>
        [JsonProperty("tax_details")]
        public OrderTaxDetailsOptions TaxDetails { get; set; }
    }
}

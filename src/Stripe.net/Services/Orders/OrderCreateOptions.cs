// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Settings for automatic tax calculation for this order.
        /// </summary>
        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public OrderAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Billing details for the customer. If a customer is provided, this will be automatically
        /// populated with values from that customer if override values are not provided.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public OrderBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer associated with this order.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The coupons, promotion codes, and/or discounts to apply to the order.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<OrderDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The IP address of the purchaser for this order.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// A list of line items the customer is ordering. Each line item includes information about
        /// the product, the quantity, and the resulting cost.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<OrderLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Payment information associated with the order, including payment settings.
        /// </summary>
        [JsonProperty("payment")]
        [STJS.JsonPropertyName("payment")]
        public OrderPaymentOptions Payment { get; set; }

        /// <summary>
        /// Settings for the customer cost of shipping for this order.
        /// </summary>
        [JsonProperty("shipping_cost")]
        [STJS.JsonPropertyName("shipping_cost")]
        public OrderShippingCostOptions ShippingCost { get; set; }

        /// <summary>
        /// Shipping details for the order.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public OrderShippingDetailsOptions ShippingDetails { get; set; }

        /// <summary>
        /// Additional tax details about the purchaser to be used for this order.
        /// </summary>
        [JsonProperty("tax_details")]
        [STJS.JsonPropertyName("tax_details")]
        public OrderTaxDetailsOptions TaxDetails { get; set; }
    }
}

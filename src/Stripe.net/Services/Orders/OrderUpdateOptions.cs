// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Settings for automatic tax calculation for this order.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public OrderAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Billing details for the customer. If a customer is provided, this will be automatically
        /// populated with values from that customer if override values are not provided.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public OrderBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// The credits to apply to the order, only <c>gift_card</c> currently supported. Pass the
        /// empty string <c>""</c> to unset this field.
        /// </summary>
        [JsonProperty("credits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credits")]
#endif
        public List<OrderCreditOptions> Credits { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The customer associated with this order.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The coupons, promotion codes, and/or discounts to apply to the order. Pass the empty
        /// string <c>""</c> to unset this field.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<OrderDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The IP address of the purchaser for this order.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }

        /// <summary>
        /// A list of line items the customer is ordering. Each line item includes information about
        /// the product, the quantity, and the resulting cost.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public List<OrderLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Payment information associated with the order, including payment settings.
        /// </summary>
        [JsonProperty("payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment")]
#endif
        public OrderPaymentOptions Payment { get; set; }

        /// <summary>
        /// Settings for the customer cost of shipping for this order.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif
        public OrderShippingCostOptions ShippingCost { get; set; }

        /// <summary>
        /// Shipping details for the order.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif
        public OrderShippingDetailsOptions ShippingDetails { get; set; }

        /// <summary>
        /// Additional tax details about the purchaser to be used for this order.
        /// </summary>
        [JsonProperty("tax_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_details")]
#endif
        public OrderTaxDetailsOptions TaxDetails { get; set; }
    }
}

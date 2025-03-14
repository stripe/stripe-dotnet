// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsPaypalLineItem : StripeEntity<PaymentIntentPaymentMethodOptionsPaypalLineItem>
    {
        /// <summary>
        /// Type of the line item.
        /// One of: <c>digital_goods</c>, <c>donation</c>, or <c>physical_goods</c>.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

        /// <summary>
        /// Description of the line item.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Descriptive name of the line item.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Quantity of the line item. Cannot be a negative number.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long Quantity { get; set; }

        /// <summary>
        /// Client facing stock keeping unit, article number or similar.
        /// </summary>
        [JsonProperty("sku")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sku")]
#endif
        public string Sku { get; set; }

        /// <summary>
        /// The Stripe account ID of the connected account that sells the item. This is only needed
        /// when using <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers">Separate Charges
        /// and Transfers</a>.
        /// </summary>
        [JsonProperty("sold_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sold_by")]
#endif
        public string SoldBy { get; set; }

        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public PaymentIntentPaymentMethodOptionsPaypalLineItemTax Tax { get; set; }

        /// <summary>
        /// Price for a single unit of the line item in minor units. Cannot be a negative number.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long UnitAmount { get; set; }
    }
}

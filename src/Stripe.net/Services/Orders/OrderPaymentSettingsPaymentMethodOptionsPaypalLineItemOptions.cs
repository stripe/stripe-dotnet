// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsPaymentMethodOptionsPaypalLineItemOptions : INestedOptions
    {
        /// <summary>
        /// Type of the line item.
        /// One of: <c>digital_goods</c>, <c>donation</c>, or <c>physical_goods</c>.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Description of the line item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Descriptive name of the line item.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Quantity of the line item. Must be a positive number.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Client facing stock keeping unit, article number or similar.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The Stripe account ID of the connected account that sells the item.
        /// </summary>
        [JsonProperty("sold_by")]
        public string SoldBy { get; set; }

        /// <summary>
        /// The tax information for the line item.
        /// </summary>
        [JsonProperty("tax")]
        public OrderPaymentSettingsPaymentMethodOptionsPaypalLineItemTaxOptions Tax { get; set; }

        /// <summary>
        /// Price for a single unit of the line item in minor units. Cannot be a negative number.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }
    }
}

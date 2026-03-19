// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The credit note line item object.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditNoteLineItem : StripeEntity<CreditNoteLineItem>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the gross amount being
        /// credited for this line item, excluding (exclusive) tax and discounts.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Description of the item being credited.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the discount being
        /// credited for this line item.
        /// </summary>
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// The amount of discount calculated per discount for this line item.
        /// </summary>
        [JsonProperty("discount_amounts")]
        [STJS.JsonPropertyName("discount_amounts")]
        public List<CreditNoteLineItemDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// ID of the invoice line item being credited.
        /// </summary>
        [JsonProperty("invoice_line_item")]
        [STJS.JsonPropertyName("invoice_line_item")]
        public string InvoiceLineItem { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The pretax credit amounts (ex: discount, credit grants, etc) for this line item.
        /// </summary>
        [JsonProperty("pretax_credit_amounts")]
        [STJS.JsonPropertyName("pretax_credit_amounts")]
        public List<CreditNoteLineItemPretaxCreditAmount> PretaxCreditAmounts { get; set; }

        /// <summary>
        /// The number of units of product being credited.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the line item.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// The tax information of the line item.
        /// </summary>
        [JsonProperty("taxes")]
        [STJS.JsonPropertyName("taxes")]
        public List<CreditNoteLineItemTax> Taxes { get; set; }

        /// <summary>
        /// The type of the credit note line item, one of <c>invoice_line_item</c> or
        /// <c>custom_line_item</c>. When the type is <c>invoice_line_item</c> there is an
        /// additional <c>invoice_line_item</c> property on the resource the value of which is the
        /// id of the credited line item on the invoice.
        /// One of: <c>custom_line_item</c>, or <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The cost of each unit of product being credited.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but contains a decimal value with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}

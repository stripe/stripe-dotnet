// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The credit note line item object.
    /// </summary>
    public class CreditNoteLineItem : StripeEntity<CreditNoteLineItem>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the gross amount being
        /// credited for this line item, excluding (exclusive) tax and discounts.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Description of the item being credited.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the discount being
        /// credited for this line item.
        /// </summary>
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif
        public long DiscountAmount { get; set; }

        /// <summary>
        /// The amount of discount calculated per discount for this line item.
        /// </summary>
        [JsonProperty("discount_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amounts")]
#endif
        public List<CreditNoteLineItemDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// ID of the invoice line item being credited.
        /// </summary>
        [JsonProperty("invoice_line_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_line_item")]
#endif
        public string InvoiceLineItem { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The pretax credit amounts (ex: discount, credit grants, etc) for this line item.
        /// </summary>
        [JsonProperty("pretax_credit_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pretax_credit_amounts")]
#endif
        public List<CreditNoteLineItemPretaxCreditAmount> PretaxCreditAmounts { get; set; }

        /// <summary>
        /// The number of units of product being credited.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the line item.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// The tax information of the line item.
        /// </summary>
        [JsonProperty("taxes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxes")]
#endif
        public List<CreditNoteLineItemTax> Taxes { get; set; }

        /// <summary>
        /// The type of the credit note line item, one of <c>invoice_line_item</c> or
        /// <c>custom_line_item</c>. When the type is <c>invoice_line_item</c> there is an
        /// additional <c>invoice_line_item</c> property on the resource the value of which is the
        /// id of the credited line item on the invoice.
        /// One of: <c>custom_line_item</c>, or <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The cost of each unit of product being credited.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but contains a decimal value with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }
    }
}

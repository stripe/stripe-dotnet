// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditNoteLineItemTaxCalculationReference : StripeEntity<CreditNoteLineItemTaxCalculationReference>
    {
        /// <summary>
        /// The calculation identifier for tax calculation response.
        /// </summary>
        [JsonProperty("calculation_id")]
        [STJS.JsonPropertyName("calculation_id")]
        public string CalculationId { get; set; }

        /// <summary>
        /// The calculation identifier for tax calculation response line item.
        /// </summary>
        [JsonProperty("calculation_item_id")]
        [STJS.JsonPropertyName("calculation_item_id")]
        public string CalculationItemId { get; set; }
    }
}

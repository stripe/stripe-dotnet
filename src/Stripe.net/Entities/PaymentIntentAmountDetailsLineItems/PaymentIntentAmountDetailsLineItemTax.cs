// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsLineItemTax : StripeEntity<PaymentIntentAmountDetailsLineItemTax>
    {
        /// <summary>
        /// The total amount of tax on the transaction represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// Required for L2 rates. An integer greater than or equal to 0.
        ///
        /// This field is mutually exclusive with the
        /// <c>amount_details[line_items][#][tax][total_tax_amount]</c> field.
        /// </summary>
        [JsonProperty("total_tax_amount")]
        [STJS.JsonPropertyName("total_tax_amount")]
        public long TotalTaxAmount { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CouponCurrencyOptions : StripeEntity<CouponCurrencyOptions>
    {
        /// <summary>
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonProperty("amount_off")]
        [STJS.JsonPropertyName("amount_off")]
        public long AmountOff { get; set; }
    }
}

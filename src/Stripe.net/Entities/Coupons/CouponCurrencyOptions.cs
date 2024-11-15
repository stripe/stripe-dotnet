// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CouponCurrencyOptions : StripeEntity<CouponCurrencyOptions>
    {
        /// <summary>
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonProperty("amount_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_off")]
#endif

        public long AmountOff { get; set; }
    }
}

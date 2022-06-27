// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CouponCurrencyOptionsXpf : StripeEntity<CouponCurrencyOptionsXpf>
    {
        /// <summary>
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonProperty("amount_off")]
        public long AmountOff { get; set; }
    }
}

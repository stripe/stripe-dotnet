// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsBlik : StripeEntity<ChargePaymentMethodDetailsBlik>
    {
        /// <summary>
        /// A unique and immutable identifier assigned by BLIK to every buyer.
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }
    }
}

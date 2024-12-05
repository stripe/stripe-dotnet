// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCashapp : StripeEntity<PaymentMethodCashapp>
    {
        /// <summary>
        /// A unique and immutable identifier assigned by Cash App to every buyer.
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// A public identifier for buyers using Cash App.
        /// </summary>
        [JsonProperty("cashtag")]
        public string Cashtag { get; set; }
    }
}

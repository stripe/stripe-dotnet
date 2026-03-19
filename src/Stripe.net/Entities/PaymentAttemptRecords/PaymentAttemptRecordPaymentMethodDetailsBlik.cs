// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsBlik : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsBlik>
    {
        /// <summary>
        /// A unique and immutable identifier assigned by BLIK to every buyer.
        /// </summary>
        [JsonProperty("buyer_id")]
        [STJS.JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }
    }
}

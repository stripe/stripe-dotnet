// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsBlik : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsBlik>
    {
        /// <summary>
        /// A unique and immutable identifier assigned by BLIK to every buyer.
        /// </summary>
        [JsonProperty("buyer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buyer_id")]
#endif
        public string BuyerId { get; set; }
    }
}

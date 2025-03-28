// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsCashapp : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCashapp>
    {
        /// <summary>
        /// A unique and immutable identifier assigned by Cash App to every buyer.
        /// </summary>
        [JsonProperty("buyer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buyer_id")]
#endif
        public string BuyerId { get; set; }

        /// <summary>
        /// A public identifier for buyers using Cash App.
        /// </summary>
        [JsonProperty("cashtag")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashtag")]
#endif
        public string Cashtag { get; set; }
    }
}

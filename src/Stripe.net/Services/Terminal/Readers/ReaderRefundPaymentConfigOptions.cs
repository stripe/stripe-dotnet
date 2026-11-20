// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderRefundPaymentConfigOptions : INestedOptions
    {
        /// <summary>
        /// Enables cancel button on transaction screens.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        [STJS.JsonPropertyName("enable_customer_cancellation")]
        public bool? EnableCustomerCancellation { get; set; }

        /// <summary>
        /// Collect a destination gift card on the reader to reload or activate with the refund
        /// amount. If omitted, refund the original gift card without collecting card data.
        /// </summary>
        [JsonProperty("gift_card")]
        [STJS.JsonPropertyName("gift_card")]
        public ReaderRefundPaymentConfigGiftCardOptions GiftCard { get; set; }
    }
}

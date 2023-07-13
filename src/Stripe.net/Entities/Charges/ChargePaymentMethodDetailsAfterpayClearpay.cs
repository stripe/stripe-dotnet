// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAfterpayClearpay : StripeEntity<ChargePaymentMethodDetailsAfterpayClearpay>
    {
        /// <summary>
        /// The Afterpay order ID associated with this payment intent.
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// Order identifier shown to the merchant in Afterpay’s online portal.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}

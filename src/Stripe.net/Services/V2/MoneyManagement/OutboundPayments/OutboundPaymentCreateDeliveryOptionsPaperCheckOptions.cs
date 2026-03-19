// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentCreateDeliveryOptionsPaperCheckOptions : INestedOptions
    {
        /// <summary>
        /// Memo printed on the memo field of the check.
        /// </summary>
        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Open Enum. Shipping speed of the paper check. Defaults to standard.
        /// One of: <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("shipping_speed")]
        [STJS.JsonPropertyName("shipping_speed")]
        public string ShippingSpeed { get; set; }

        /// <summary>
        /// Signature for the paper check.
        /// </summary>
        [JsonProperty("signature")]
        [STJS.JsonPropertyName("signature")]
        public string Signature { get; set; }
    }
}

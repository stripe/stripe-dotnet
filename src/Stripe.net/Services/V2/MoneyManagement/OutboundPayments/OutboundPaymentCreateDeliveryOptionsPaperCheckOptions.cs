// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentCreateDeliveryOptionsPaperCheckOptions : INestedOptions
    {
        /// <summary>
        /// Memo printed on the memo field of the check.
        /// </summary>
        [JsonProperty("memo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("memo")]
#endif
        public string Memo { get; set; }

        /// <summary>
        /// Open Enum. Shipping speed of the paper check. Defaults to standard.
        /// One of: <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("shipping_speed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_speed")]
#endif
        public string ShippingSpeed { get; set; }

        /// <summary>
        /// Signature for the paper check.
        /// </summary>
        [JsonProperty("signature")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("signature")]
#endif
        public string Signature { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Some customers might be required by their company or organization to provide this
        /// information. If so, provide this value. Otherwise you can ignore this field.
        /// </summary>
        [JsonProperty("customer_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_reference")]
#endif
        public string CustomerReference { get; set; }

        /// <summary>
        /// A unique value assigned by the business to identify the transaction.
        /// </summary>
        [JsonProperty("order_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_reference")]
#endif
        public string OrderReference { get; set; }
    }
}

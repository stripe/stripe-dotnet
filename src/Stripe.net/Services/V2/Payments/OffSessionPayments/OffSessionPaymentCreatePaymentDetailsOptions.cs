// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreatePaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// A unique value to identify the customer. This field is applicable only for card
        /// payments. For card payments, this field is truncated to 25 alphanumeric characters,
        /// excluding spaces, before being sent to card networks.
        /// </summary>
        [JsonProperty("customer_reference")]
        [STJS.JsonPropertyName("customer_reference")]
        public string CustomerReference { get; set; }

        /// <summary>
        /// A unique value assigned by the business to identify the transaction. Required for L2 and
        /// L3 rates. For Cards, this field is truncated to 25 alphanumeric characters, excluding
        /// spaces, before being sent to card networks.
        /// </summary>
        [JsonProperty("order_reference")]
        [STJS.JsonPropertyName("order_reference")]
        public string OrderReference { get; set; }
    }
}

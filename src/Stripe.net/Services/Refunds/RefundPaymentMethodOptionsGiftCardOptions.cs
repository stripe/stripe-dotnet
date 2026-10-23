// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RefundPaymentMethodOptionsGiftCardOptions : INestedOptions
    {
        /// <summary>
        /// The type of gift card operation to perform for the refund.
        /// One of: <c>activation</c>, or <c>reload</c>.
        /// </summary>
        [JsonProperty("operation_type")]
        [STJS.JsonPropertyName("operation_type")]
        public string OperationType { get; set; }
    }
}

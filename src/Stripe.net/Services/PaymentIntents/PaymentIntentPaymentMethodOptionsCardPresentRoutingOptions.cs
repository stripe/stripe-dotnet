// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCardPresentRoutingOptions : INestedOptions
    {
        /// <summary>
        /// Routing requested priority.
        /// One of: <c>domestic</c>, or <c>international</c>.
        /// </summary>
        [JsonProperty("requested_priority")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_priority")]
#endif

        public string RequestedPriority { get; set; }
    }
}

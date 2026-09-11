// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentRoutingOptions : INestedOptions
    {
        /// <summary>
        /// Routing requested priority.
        /// One of: <c>domestic</c>, or <c>international</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("requested_priority")]
        [STJS.JsonPropertyName("requested_priority")]
        public string RequestedPriority { get; set; }
    }
}

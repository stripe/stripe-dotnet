// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardPresentRoutingOptions : INestedOptions
    {
        /// <summary>
        /// Routing requested priority.
        /// One of: <c>domestic</c>, or <c>international</c>.
        /// </summary>
        [JsonProperty("requested_priority")]
        public string RequestedPriority { get; set; }
    }
}

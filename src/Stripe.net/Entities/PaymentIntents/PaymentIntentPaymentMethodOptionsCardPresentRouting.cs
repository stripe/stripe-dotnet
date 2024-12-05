// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardPresentRouting : StripeEntity<PaymentIntentPaymentMethodOptionsCardPresentRouting>
    {
        /// <summary>
        /// Requested routing priority.
        /// One of: <c>domestic</c>, or <c>international</c>.
        /// </summary>
        [JsonProperty("requested_priority")]
        public string RequestedPriority { get; set; }
    }
}

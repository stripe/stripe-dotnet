// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardPartialAuthorization : StripeEntity<ChargePaymentMethodDetailsCardPartialAuthorization>
    {
        /// <summary>
        /// Indicates whether the transaction requested for partial authorization feature and the
        /// authorization outcome.
        /// One of: <c>declined</c>, <c>fully_authorized</c>, <c>not_requested</c>, or
        /// <c>partially_authorized</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

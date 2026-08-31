// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionPaymentMethodOptionsCard : StripeEntity<RequestedSessionPaymentMethodOptionsCard>
    {
        /// <summary>
        /// The card brands blocked by the agent.
        /// One of: <c>american_express</c>, <c>mastercard</c>, or <c>visa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("brands_blocked")]
        [STJS.JsonPropertyName("brands_blocked")]
        public List<string> BrandsBlocked { get; set; }
    }
}

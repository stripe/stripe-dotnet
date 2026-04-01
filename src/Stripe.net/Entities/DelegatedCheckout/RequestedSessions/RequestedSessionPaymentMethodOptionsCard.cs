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
        /// </summary>
        [JsonProperty("brands_blocked")]
        [STJS.JsonPropertyName("brands_blocked")]
        public List<string> BrandsBlocked { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// The card brands to exclude from the session.
        /// One of: <c>american_express</c>, <c>mastercard</c>, or <c>visa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("brands_blocked")]
        [STJS.JsonPropertyName("brands_blocked")]
        public List<string> BrandsBlocked { get; set; }
    }
}

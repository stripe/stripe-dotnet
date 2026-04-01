// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Card-specific payment method options.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public RequestedSessionPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// The payment method types to exclude from the session.
        /// One of: <c>affirm</c>, <c>card</c>, or <c>klarna</c>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types")]
        [STJS.JsonPropertyName("excluded_payment_method_types")]
        public List<string> ExcludedPaymentMethodTypes { get; set; }
    }
}

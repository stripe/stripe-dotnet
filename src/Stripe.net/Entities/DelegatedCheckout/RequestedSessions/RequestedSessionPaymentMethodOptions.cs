// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionPaymentMethodOptions : StripeEntity<RequestedSessionPaymentMethodOptions>
    {
        /// <summary>
        /// Card-specific payment method options.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public RequestedSessionPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// The computed displayable card brands.
        /// One of: <c>american_express</c>, <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("displayable_card_brands")]
        [STJS.JsonPropertyName("displayable_card_brands")]
        public List<string> DisplayableCardBrands { get; set; }

        /// <summary>
        /// The computed displayable payment method types.
        /// One of: <c>affirm</c>, <c>card</c>, or <c>klarna</c>.
        /// </summary>
        [JsonProperty("displayable_payment_method_types")]
        [STJS.JsonPropertyName("displayable_payment_method_types")]
        public List<string> DisplayablePaymentMethodTypes { get; set; }

        /// <summary>
        /// The payment method types excluded by the agent.
        /// One of: <c>affirm</c>, <c>card</c>, or <c>klarna</c>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types")]
        [STJS.JsonPropertyName("excluded_payment_method_types")]
        public List<string> ExcludedPaymentMethodTypes { get; set; }
    }
}

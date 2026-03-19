// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// This sub-hash contains line item details that are specific to the <c>card</c> payment
        /// method.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// This sub-hash contains line item details that are specific to the <c>card_present</c>
        /// payment method.
        /// </summary>
        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// This sub-hash contains line item details that are specific to the <c>klarna</c> payment
        /// method.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// This sub-hash contains line item details that are specific to the <c>paypal</c> payment
        /// method.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsPaypalOptions Paypal { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// This sub-hash contains line item details that are specific to <c>card</c> payment
        /// method.".
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// This sub-hash contains line item details that are specific to <c>card_present</c>
        /// payment method.".
        /// </summary>
        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// This sub-hash contains line item details that are specific to <c>klarna</c> payment
        /// method.".
        /// </summary>
        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// This sub-hash contains line item details that are specific to <c>paypal</c> payment
        /// method.".
        /// </summary>
        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsPaypalOptions Paypal { get; set; }
    }
}

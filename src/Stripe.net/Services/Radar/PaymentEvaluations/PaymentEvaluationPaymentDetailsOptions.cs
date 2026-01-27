// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationPaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The intended amount to collect with this payment. A positive integer representing how
        /// much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a> (for example, 100 cents to charge 1.00 USD or 100 to charge 100 Yen, a
        /// zero-decimal currency).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Details about the payment's customer presence and type.
        /// </summary>
        [JsonProperty("money_movement_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("money_movement_details")]
#endif
        public PaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions MoneyMovementDetails { get; set; }

        /// <summary>
        /// Details about the payment method to use for the payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_details")]
#endif
        public PaymentEvaluationPaymentDetailsPaymentMethodDetailsOptions PaymentMethodDetails { get; set; }

        /// <summary>
        /// Shipping details for the payment evaluation.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif
        public PaymentEvaluationPaymentDetailsShippingDetailsOptions ShippingDetails { get; set; }

        /// <summary>
        /// Payment statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}

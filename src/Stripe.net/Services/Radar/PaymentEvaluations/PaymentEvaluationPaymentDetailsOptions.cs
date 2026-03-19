// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationPaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The intended amount to collect with this payment. A positive integer representing how
        /// much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a> (for example, 100 cents to charge 1.00 USD or 100 to charge 100 Yen, a
        /// zero-decimal currency).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Details about the payment's customer presence and type.
        /// </summary>
        [JsonProperty("money_movement_details")]
        [STJS.JsonPropertyName("money_movement_details")]
        public PaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions MoneyMovementDetails { get; set; }

        /// <summary>
        /// Details about the payment method to use for the payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        [STJS.JsonPropertyName("payment_method_details")]
        public PaymentEvaluationPaymentDetailsPaymentMethodDetailsOptions PaymentMethodDetails { get; set; }

        /// <summary>
        /// Shipping details for the payment evaluation.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public PaymentEvaluationPaymentDetailsShippingDetailsOptions ShippingDetails { get; set; }

        /// <summary>
        /// Payment statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationPaymentDetails : StripeEntity<PaymentEvaluationPaymentDetails>
    {
        /// <summary>
        /// Amount intended to be collected by this payment. A positive integer representing how
        /// much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal
        /// currency). The minimum amount is $0.50 US or <a
        /// href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

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
        public PaymentEvaluationPaymentDetailsMoneyMovementDetails MoneyMovementDetails { get; set; }

        /// <summary>
        /// Details about the payment method used for the payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        [STJS.JsonPropertyName("payment_method_details")]
        public PaymentEvaluationPaymentDetailsPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// Shipping details for the payment evaluation.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public PaymentEvaluationPaymentDetailsShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Payment statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}

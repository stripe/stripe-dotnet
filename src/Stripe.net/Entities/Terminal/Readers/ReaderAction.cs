// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderAction : StripeEntity<ReaderAction>
    {
        /// <summary>
        /// Represents a reader action to collect customer inputs.
        /// </summary>
        [JsonProperty("collect_inputs")]
        [STJS.JsonPropertyName("collect_inputs")]
        public ReaderActionCollectInputs CollectInputs { get; set; }

        /// <summary>
        /// Represents a reader action to collect a payment method.
        /// </summary>
        [JsonProperty("collect_payment_method")]
        [STJS.JsonPropertyName("collect_payment_method")]
        public ReaderActionCollectPaymentMethod CollectPaymentMethod { get; set; }

        /// <summary>
        /// Represents a reader action to confirm a payment.
        /// </summary>
        [JsonProperty("confirm_payment_intent")]
        [STJS.JsonPropertyName("confirm_payment_intent")]
        public ReaderActionConfirmPaymentIntent ConfirmPaymentIntent { get; set; }

        /// <summary>
        /// Failure code, only set if status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failure_code")]
        [STJS.JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Detailed failure message, only set if status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failure_message")]
        [STJS.JsonPropertyName("failure_message")]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Represents a reader action to process a payment intent.
        /// </summary>
        [JsonProperty("process_payment_intent")]
        [STJS.JsonPropertyName("process_payment_intent")]
        public ReaderActionProcessPaymentIntent ProcessPaymentIntent { get; set; }

        /// <summary>
        /// Represents a reader action to process a setup intent.
        /// </summary>
        [JsonProperty("process_setup_intent")]
        [STJS.JsonPropertyName("process_setup_intent")]
        public ReaderActionProcessSetupIntent ProcessSetupIntent { get; set; }

        /// <summary>
        /// Represents a reader action to refund a payment.
        /// </summary>
        [JsonProperty("refund_payment")]
        [STJS.JsonPropertyName("refund_payment")]
        public ReaderActionRefundPayment RefundPayment { get; set; }

        /// <summary>
        /// Represents a reader action to set the reader display.
        /// </summary>
        [JsonProperty("set_reader_display")]
        [STJS.JsonPropertyName("set_reader_display")]
        public ReaderActionSetReaderDisplay SetReaderDisplay { get; set; }

        /// <summary>
        /// Status of the action performed by the reader.
        /// One of: <c>failed</c>, <c>in_progress</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of action performed by the reader.
        /// One of: <c>collect_inputs</c>, <c>collect_payment_method</c>,
        /// <c>confirm_payment_intent</c>, <c>process_payment_intent</c>,
        /// <c>process_setup_intent</c>, <c>refund_payment</c>, or <c>set_reader_display</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

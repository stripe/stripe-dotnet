// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderAction : StripeEntity<ReaderAction>
    {
        /// <summary>
        /// Failure code, only set if status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Detailed failure message, only set if status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Represents a reader action to process a payment intent.
        /// </summary>
        [JsonProperty("process_payment_intent")]
        public ReaderActionProcessPaymentIntent ProcessPaymentIntent { get; set; }

        /// <summary>
        /// Represents a reader action to process a setup intent.
        /// </summary>
        [JsonProperty("process_setup_intent")]
        public ReaderActionProcessSetupIntent ProcessSetupIntent { get; set; }

        /// <summary>
        /// Represents a reader action to refund a payment.
        /// </summary>
        [JsonProperty("refund_payment")]
        public ReaderActionRefundPayment RefundPayment { get; set; }

        /// <summary>
        /// Represents a reader action to set the reader display.
        /// </summary>
        [JsonProperty("set_reader_display")]
        public ReaderActionSetReaderDisplay SetReaderDisplay { get; set; }

        /// <summary>
        /// Status of the action performed by the reader.
        /// One of: <c>failed</c>, <c>in_progress</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of action performed by the reader.
        /// One of: <c>process_payment_intent</c>, <c>process_setup_intent</c>,
        /// <c>refund_payment</c>, or <c>set_reader_display</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

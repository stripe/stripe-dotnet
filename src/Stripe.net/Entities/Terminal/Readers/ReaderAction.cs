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
        /// Represents a reader action to activate a gift card.
        /// </summary>
        [JsonProperty("activate_gift_card")]
        [STJS.JsonPropertyName("activate_gift_card")]
        public ReaderActionActivateGiftCard ActivateGiftCard { get; set; }

        /// <summary>
        /// The reader action failed due to an <a href="https://docs.stripe.com/api/errors">API
        /// error</a>. Only present when <c>status</c> is <c>failed</c> and the underlying failure
        /// was an API error. Avoid parsing the <c>message</c> field for programmatic logic; use
        /// <c>type</c> or <c>code</c> instead. The <c>message</c> field is for display to humans
        /// only and may be updated at anytime. Requires <a
        /// href="https://docs.stripe.com/terminal/readers/stripe-reader-s700-s710#reader-software-version">reader
        /// version</a> 2.42 or later. Readers on older versions always return null.
        /// </summary>
        [JsonProperty("api_error")]
        [STJS.JsonPropertyName("api_error")]
        public StripeError ApiError { get; set; }

        /// <summary>
        /// Represents a reader action to cash out a gift card.
        /// </summary>
        [JsonProperty("cashout_gift_card")]
        [STJS.JsonPropertyName("cashout_gift_card")]
        public ReaderActionCashoutGiftCard CashoutGiftCard { get; set; }

        /// <summary>
        /// Represents a reader action to check a gift card balance.
        /// </summary>
        [JsonProperty("check_gift_card_balance")]
        [STJS.JsonPropertyName("check_gift_card_balance")]
        public ReaderActionCheckGiftCardBalance CheckGiftCardBalance { get; set; }

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
        /// Represents a reader action to deactivate a gift card.
        /// </summary>
        [JsonProperty("deactivate_gift_card")]
        [STJS.JsonPropertyName("deactivate_gift_card")]
        public ReaderActionDeactivateGiftCard DeactivateGiftCard { get; set; }

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
        /// Represents a reader action to print content.
        /// </summary>
        [JsonProperty("print_content")]
        [STJS.JsonPropertyName("print_content")]
        public ReaderActionPrintContent PrintContent { get; set; }

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
        /// Represents a reader action to reload a gift card.
        /// </summary>
        [JsonProperty("reload_gift_card")]
        [STJS.JsonPropertyName("reload_gift_card")]
        public ReaderActionReloadGiftCard ReloadGiftCard { get; set; }

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
        /// One of: <c>activate_gift_card</c>, <c>cashout_gift_card</c>,
        /// <c>check_gift_card_balance</c>, <c>collect_inputs</c>, <c>collect_payment_method</c>,
        /// <c>confirm_payment_intent</c>, <c>deactivate_gift_card</c>, <c>print_content</c>,
        /// <c>process_payment_intent</c>, <c>process_setup_intent</c>, <c>refund_payment</c>,
        /// <c>reload_gift_card</c>, or <c>set_reader_display</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

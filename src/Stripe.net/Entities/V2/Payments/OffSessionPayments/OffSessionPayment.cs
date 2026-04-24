// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An OffSessionPayment allows you to create your own payment flow for recurring and
    /// unscheduled payments. In a single API request, you can initiate a payment and leverage
    /// Stripe's AI-powered <a
    /// href="https://docs.stripe.com/payments/off-session-payments/smart-retries">Smart
    /// Retries</a> to choose the best times to retry failures to increase the chance of a
    /// successful payment. To properly interface with OffSessionPayments, we recommend setting
    /// up an event destination to listen to webhook notifications, as the OffSessionPayment
    /// will transition through its lifecycle asynchronously. Related guide: <a
    /// href="https://docs.stripe.com/payments/off-session-payments">Off-Session Payments
    /// API</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPayment : StripeEntity<OffSessionPayment>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The amount available to be captured.
        /// </summary>
        [JsonProperty("amount_capturable")]
        [STJS.JsonPropertyName("amount_capturable")]
        public V2.Amount AmountCapturable { get; set; }

        /// <summary>
        /// Provides industry-specific information about the amount.
        /// </summary>
        [JsonProperty("amount_details")]
        [STJS.JsonPropertyName("amount_details")]
        public OffSessionPaymentAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// The “presentment amount” to be collected from the customer.
        /// </summary>
        [JsonProperty("amount_requested")]
        [STJS.JsonPropertyName("amount_requested")]
        public V2.Amount AmountRequested { get; set; }

        /// <summary>
        /// The amount of the application fee requested to be applied to the payment.
        /// </summary>
        [JsonProperty("application_fee_amount_requested")]
        [STJS.JsonPropertyName("application_fee_amount_requested")]
        public V2.Amount ApplicationFeeAmountRequested { get; set; }

        /// <summary>
        /// The frequency of the underlying payment.
        /// One of: <c>recurring</c>, or <c>unscheduled</c>.
        /// </summary>
        [JsonProperty("cadence")]
        [STJS.JsonPropertyName("cadence")]
        public string Cadence { get; set; }

        /// <summary>
        /// Details about the capture configuration for the OffSessionPayment.
        /// </summary>
        [JsonProperty("capture")]
        [STJS.JsonPropertyName("capture")]
        public OffSessionPaymentCapture Capture { get; set; }

        /// <summary>
        /// Creation time of the OffSessionPayment. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// ID of the Customer to which this OffSessionPayment belongs.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The reason why the OffSessionPayment failed.
        /// One of: <c>authorization_expired</c>, <c>exceeded_retry_window</c>,
        /// <c>no_valid_payment_method</c>, <c>rejected_by_partner</c>, or <c>retries_exhausted</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// The payment error encountered in the previous attempt to authorize the payment.
        /// </summary>
        [JsonProperty("last_authorization_attempt_error")]
        [STJS.JsonPropertyName("last_authorization_attempt_error")]
        public string LastAuthorizationAttemptError { get; set; }

        /// <summary>
        /// Payment attempt record for the latest attempt, if one exists.
        /// </summary>
        [JsonProperty("latest_payment_attempt_record")]
        [STJS.JsonPropertyName("latest_payment_attempt_record")]
        public string LatestPaymentAttemptRecord { get; set; }

        /// <summary>
        /// Has the value true if the object exists in live mode or the value false if the object
        /// exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Learn more about <a
        /// href="https://docs.stripe.com/payments/payment-intents#storing-information-in-metadata">storing
        /// information in metadata</a>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the OffSessionPayment are intended.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Provides industry-specific information about the payment.
        /// </summary>
        [JsonProperty("payment_details")]
        [STJS.JsonPropertyName("payment_details")]
        public OffSessionPaymentPaymentDetails PaymentDetails { get; set; }

        /// <summary>
        /// ID of the payment method used in this OffSessionPayment.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Payment record associated with the OffSessionPayment.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }

        /// <summary>
        /// Details about the payments orchestration configuration.
        /// </summary>
        [JsonProperty("payments_orchestration")]
        [STJS.JsonPropertyName("payments_orchestration")]
        public OffSessionPaymentPaymentsOrchestration PaymentsOrchestration { get; set; }

        /// <summary>
        /// Details about the OffSessionPayment retries.
        /// </summary>
        [JsonProperty("retry_details")]
        [STJS.JsonPropertyName("retry_details")]
        public OffSessionPaymentRetryDetails RetryDetails { get; set; }

        /// <summary>
        /// Text that appears on the customer’s statement as the statement descriptor for a non-card
        /// charge. This value overrides the account’s default statement descriptor. For information
        /// about requirements, including the 22-character limit, see the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">Statement
        /// Descriptor docs</a>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account’s <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer’s statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Status of this OffSessionPayment, one of <c>pending</c>, <c>pending_retry</c>,
        /// <c>processing</c>, <c>failed</c>, <c>canceled</c>, <c>requires_capture</c>, or
        /// <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>paused</c>, <c>pending</c>,
        /// <c>pending_retry</c>, <c>processing</c>, <c>requires_capture</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Test clock that can be used to advance the retry attempts in a sandbox.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }

        /// <summary>
        /// The data that automatically creates a Transfer after the payment finalizes. Learn more
        /// about the use case for <a
        /// href="https://docs.stripe.com/payments/connected-accounts">connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public OffSessionPaymentTransferData TransferData { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// OffSessionPayment resource.
    /// </summary>
    public class OffSessionPayment : StripeEntity<OffSessionPayment>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The amount available to be captured.
        /// </summary>
        [JsonProperty("amount_capturable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_capturable")]
#endif
        public V2.Amount AmountCapturable { get; set; }

        /// <summary>
        /// Provides industry-specific information about the amount.
        /// </summary>
        [JsonProperty("amount_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_details")]
#endif
        public OffSessionPaymentAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// The “presentment amount” to be collected from the customer.
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public V2.Amount AmountRequested { get; set; }

        /// <summary>
        /// The frequency of the underlying payment.
        /// One of: <c>recurring</c>, or <c>unscheduled</c>.
        /// </summary>
        [JsonProperty("cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cadence")]
#endif
        public string Cadence { get; set; }

        /// <summary>
        /// Details about the capture configuration for the OffSessionPayment.
        /// </summary>
        [JsonProperty("capture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture")]
#endif
        public OffSessionPaymentCapture Capture { get; set; }

        /// <summary>
        /// Whether the OffSessionPayment should be captured automatically or manually.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }

        /// <summary>
        /// ID of the owning compartment.
        /// </summary>
        [JsonProperty("compartment_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("compartment_id")]
#endif
        public string CompartmentId { get; set; }

        /// <summary>
        /// Creation time of the OffSessionPayment. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// ID of the Customer to which this OffSessionPayment belongs.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The reason why the OffSessionPayment failed.
        /// One of: <c>authorization_expired</c>, <c>rejected_by_partner</c>, or
        /// <c>retries_exhausted</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_reason")]
#endif
        public string FailureReason { get; set; }

        /// <summary>
        /// The payment error encountered in the previous attempt to authorize the payment.
        /// </summary>
        [JsonProperty("last_authorization_attempt_error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_authorization_attempt_error")]
#endif
        public string LastAuthorizationAttemptError { get; set; }

        /// <summary>
        /// Payment attempt record for the latest attempt, if one exists.
        /// </summary>
        [JsonProperty("latest_payment_attempt_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_payment_attempt_record")]
#endif
        public string LatestPaymentAttemptRecord { get; set; }

        /// <summary>
        /// Has the value true if the object exists in live mode or the value false if the object
        /// exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.corp.stripe.com/api/metadata">key-value pairs</a> that you
        /// can attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Learn more about <a
        /// href="https://docs.corp.stripe.com/payments/payment-intents#storing-information-in-metadata">storing
        /// information in metadata</a>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the OffSessionPayment are intended.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the payment method used in this OffSessionPayment.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Payment record associated with the OffSessionPayment.
        /// </summary>
        [JsonProperty("payment_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record")]
#endif
        public string PaymentRecord { get; set; }

        /// <summary>
        /// Details about the payments orchestration configuration.
        /// </summary>
        [JsonProperty("payments_orchestration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments_orchestration")]
#endif
        public OffSessionPaymentPaymentsOrchestration PaymentsOrchestration { get; set; }

        /// <summary>
        /// Details about the OffSessionPayment retries.
        /// </summary>
        [JsonProperty("retry_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retry_details")]
#endif
        public OffSessionPaymentRetryDetails RetryDetails { get; set; }

        /// <summary>
        /// Text that appears on the customer’s statement as the statement descriptor for a non-card
        /// charge. This value overrides the account’s default statement descriptor. For information
        /// about requirements, including the 22-character limit, see the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">Statement
        /// Descriptor docs</a>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account’s <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer’s statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Status of this OffSessionPayment, one of <c>pending</c>, <c>pending_retry</c>,
        /// <c>processing</c>, <c>failed</c>, <c>canceled</c>, <c>requires_capture</c>, or
        /// <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, <c>pending_retry</c>,
        /// <c>processing</c>, <c>requires_capture</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Test clock that can be used to advance the retry attempts in a sandbox.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }

        /// <summary>
        /// The data that automatically creates a Transfer after the payment finalizes. Learn more
        /// about the use case for <a
        /// href="https://docs.corp.stripe.com/payments/connected-accounts">connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public OffSessionPaymentTransferData TransferData { get; set; }
    }
}

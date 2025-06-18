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
    /// Off-session payment resource.
    /// </summary>
    public class OffSessionPayment : StripeEntity<OffSessionPayment>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// ID of the OSP.
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
        /// The amount you requested to be collected on the OSP upon creation.
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public V2.Amount AmountRequested { get; set; }

        /// <summary>
        /// The frequency of the underlying payment that this OSP represents.
        /// One of: <c>recurring</c>, or <c>unscheduled</c>.
        /// </summary>
        [JsonProperty("cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cadence")]
#endif
        public string Cadence { get; set; }

        /// <summary>
        /// ID of owning compartment.
        /// </summary>
        [JsonProperty("compartment_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("compartment_id")]
#endif
        public string CompartmentId { get; set; }

        /// <summary>
        /// Timestamp of creation.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Customer owning the supplied payment method.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Reason why the OSP failed.
        /// One of: <c>rejected_by_partner</c>, or <c>retries_exhausted</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_reason")]
#endif
        public string FailureReason { get; set; }

        /// <summary>
        /// Last error returned by the financial partner for a failed authorization.
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
        /// True if the txn is livemode, false otherwise.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Metadata you provided.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// OBO, same as on the PI.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of payment method.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Payment record associated with the OSP. consistent across attempts.
        /// </summary>
        [JsonProperty("payment_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record")]
#endif
        public string PaymentRecord { get; set; }

        /// <summary>
        /// Details about the OSP retries.
        /// </summary>
        [JsonProperty("retry_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retry_details")]
#endif
        public OffSessionPaymentRetryDetails RetryDetails { get; set; }

        /// <summary>
        /// Statement descriptor you provided.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Statement descriptor suffix you provided, similar to that on the PI.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Status of the OSP.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, <c>pending_retry</c>,
        /// <c>processing</c>, <c>requires_capture</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Test clock to be used to advance the retry attempts.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }

        /// <summary>
        /// Instructions for the transfer to be made with this OSP after successful money movement.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public OffSessionPaymentTransferData TransferData { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An approval request represents a pending action that requires review before execution.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApprovalRequest : StripeEntity<ApprovalRequest>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier for this ApprovalRequest.
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
        /// The action that was requested.
        /// One of: <c>charge.create</c>, <c>dispute.close</c>,
        /// <c>inbound_transfers.money_management.create</c>, <c>invoice.create</c>,
        /// <c>outbound_payments.money_management.create</c>,
        /// <c>outbound_transfers.money_management.create</c>, <c>payment_intent.create</c>,
        /// <c>payment_intent.update</c>, <c>payout.create</c>, <c>price.update</c>,
        /// <c>refund.create</c>, <c>setup_intent.create</c>, <c>subscription.create</c>,
        /// <c>subscription.update</c>, <c>topup.create</c>, or <c>transfer.create</c>.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Time this ApprovalRequest was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL to the dashboard for this ApprovalRequest.
        /// </summary>
        [JsonProperty("dashboard_url")]
        [STJS.JsonPropertyName("dashboard_url")]
        public string DashboardUrl { get; set; }

        /// <summary>
        /// A description of the approval request.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The timestamp at which this ApprovalRequest will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this ApprovalRequest is livemode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The requester of this ApprovalRequest.
        /// </summary>
        [JsonProperty("requested_by")]
        [STJS.JsonPropertyName("requested_by")]
        public ApprovalRequestRequestedBy RequestedBy { get; set; }

        /// <summary>
        /// The review of this ApprovalRequest if it has been reviewed.
        /// </summary>
        [JsonProperty("review")]
        [STJS.JsonPropertyName("review")]
        public ApprovalRequestReview Review { get; set; }

        /// <summary>
        /// The rule associated with this ApprovalRequest.
        /// </summary>
        [JsonProperty("rule")]
        [STJS.JsonPropertyName("rule")]
        public ApprovalRequestRule Rule { get; set; }

        /// <summary>
        /// The status of this ApprovalRequest.
        /// One of: <c>approved</c>, <c>canceled</c>, <c>execution_failed</c>,
        /// <c>execution_started</c>, <c>execution_succeeded</c>, <c>expired</c>, <c>failed</c>,
        /// <c>pending</c>, <c>rejected</c>, <c>requires_execution</c>, <c>requires_review</c>, or
        /// <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The details of the status of this ApprovalRequest.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public ApprovalRequestStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The transitions of the status of this ApprovalRequest.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public ApprovalRequestStatusTransitions StatusTransitions { get; set; }
    }
}

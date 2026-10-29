// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// RecipientVerification represents a verification of recipient you intend to send funds
    /// to.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RecipientVerification : StripeEntity<RecipientVerification>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the RecipientVerification.
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
        /// The resource that consumed this verification.
        /// </summary>
        [JsonProperty("consumed_by")]
        [STJS.JsonPropertyName("consumed_by")]
        public RecipientVerificationConsumedBy ConsumedBy { get; set; }

        /// <summary>
        /// Time at which the RecipientVerification was created. Represented as a RFC 3339 date
        /// &amp; time UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the RecipientVerification expires, 5 minutes after the creation. Only
        /// applicable for Verification of Payee (VoP) verifications. Represented as a RFC 3339 date
        /// &amp; time UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime? ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Closed Enum. Match level of the RecipientVerification: <c>match</c>, <c>close_match</c>,
        /// <c>no_match</c>, <c>unavailable</c>.
        /// One of: <c>close_match</c>, <c>match</c>, <c>no_match</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("match_result")]
        [STJS.JsonPropertyName("match_result")]
        public string MatchResult { get; set; }

        /// <summary>
        /// Details for the match result.
        /// </summary>
        [JsonProperty("match_result_details")]
        [STJS.JsonPropertyName("match_result_details")]
        public RecipientVerificationMatchResultDetails MatchResultDetails { get; set; }

        /// <summary>
        /// ID of the payout method that was verified.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }

        /// <summary>
        /// ID of the recipient account. Omitted for same-entity payouts.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// Current status of the recipient verification.
        /// One of: <c>acknowledged</c>, <c>awaiting_acknowledgement</c>, <c>consumed</c>,
        /// <c>expired</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Hash containing timestamps of when the object transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public RecipientVerificationStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Open Enum. The type of verification performed: <c>verification_of_payee</c>,
        /// <c>confirmation_of_payee</c>.
        /// One of: <c>confirmation_of_payee</c>, or <c>verification_of_payee</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("verification_type")]
        [STJS.JsonPropertyName("verification_type")]
        public string VerificationType { get; set; }
    }
}

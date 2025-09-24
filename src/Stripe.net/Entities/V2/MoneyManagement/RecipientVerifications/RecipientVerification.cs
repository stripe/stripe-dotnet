// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// RecipientVerification represents a verification of recipient you intend to send funds
    /// to.
    /// </summary>
    public class RecipientVerification : StripeEntity<RecipientVerification>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the RecipientVerification.
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
        /// The OBP/OBT ID that consumed this verification, present if one is successfully created.
        /// </summary>
        [JsonProperty("consumed_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consumed_by")]
#endif
        public string ConsumedBy { get; set; }

        /// <summary>
        /// Time at which the RecipientVerification was created. Represented as a RFC 3339 date
        /// &amp; time UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the RecipientVerification expires, 5 minutes after the creation.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Closed Enum. Match level of the RecipientVerification: <c>match</c>, <c>close_match</c>,
        /// <c>no_match</c>, <c>unavailable</c>.
        /// One of: <c>close_match</c>, <c>match</c>, <c>no_match</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("match_result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("match_result")]
#endif
        public string MatchResult { get; set; }

        /// <summary>
        /// Details for the match result.
        /// </summary>
        [JsonProperty("match_result_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("match_result_details")]
#endif
        public RecipientVerificationMatchResultDetails MatchResultDetails { get; set; }

        /// <summary>
        /// Closed Enum. Current status of the RecipientVerification: <c>verified</c>,
        /// <c>consumed</c>, <c>expired</c>, <c>awaiting_acknowledgement</c>, <c>acknowledged</c>.
        /// One of: <c>acknowledged</c>, <c>awaiting_acknowledgement</c>, <c>consumed</c>,
        /// <c>expired</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Hash containing timestamps of when the object transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif
        public RecipientVerificationStatusTransitions StatusTransitions { get; set; }
    }
}

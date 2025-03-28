// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GbBankAccountConfirmationOfPayeeResult : StripeEntity<GbBankAccountConfirmationOfPayeeResult>
    {
        /// <summary>
        /// When the CoP result was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether or not the information of the bank account matches what you have provided.
        /// Closed enum.
        /// One of: <c>match</c>, <c>mismatch</c>, <c>partial_match</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("match_result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("match_result")]
#endif
        public string MatchResult { get; set; }

        /// <summary>
        /// The fields that CoP service matched against. Only has value if MATCH or PARTIAL_MATCH,
        /// empty otherwise.
        /// </summary>
        [JsonProperty("matched")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("matched")]
#endif
        public GbBankAccountConfirmationOfPayeeResultMatched Matched { get; set; }

        /// <summary>
        /// Human-readable message describing the match result.
        /// </summary>
        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }

        /// <summary>
        /// The fields that are matched against what the network has on file.
        /// </summary>
        [JsonProperty("provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("provided")]
#endif
        public GbBankAccountConfirmationOfPayeeResultProvided Provided { get; set; }
    }
}

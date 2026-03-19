// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GbBankAccountConfirmationOfPayeeResult : StripeEntity<GbBankAccountConfirmationOfPayeeResult>
    {
        /// <summary>
        /// When the CoP result was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether or not the information of the bank account matches what you have provided.
        /// Closed enum.
        /// One of: <c>match</c>, <c>mismatch</c>, <c>partial_match</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("match_result")]
        [STJS.JsonPropertyName("match_result")]
        public string MatchResult { get; set; }

        /// <summary>
        /// The fields that CoP service matched against. Only has value if MATCH or PARTIAL_MATCH,
        /// empty otherwise.
        /// </summary>
        [JsonProperty("matched")]
        [STJS.JsonPropertyName("matched")]
        public GbBankAccountConfirmationOfPayeeResultMatched Matched { get; set; }

        /// <summary>
        /// Human-readable message describing the match result.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// The fields that are matched against what the network has on file.
        /// </summary>
        [JsonProperty("provided")]
        [STJS.JsonPropertyName("provided")]
        public GbBankAccountConfirmationOfPayeeResultProvided Provided { get; set; }
    }
}

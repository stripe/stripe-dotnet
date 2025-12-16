// File generated from our OpenAPI spec
namespace Stripe.V2.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MoneyManagementRecipientVerificationsOptions : BaseOptions
    {
        /// <summary>
        /// Expected match level of the RecipientVerification to be created: <c>match</c>,
        /// <c>close_match</c>, <c>no_match</c>, <c>unavailable</c>. For <c>close_match</c>, the
        /// simulated response appends "close_match" to the provided name in
        /// match_result_details.matched_name.
        /// One of: <c>close_match</c>, <c>match</c>, <c>no_match</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("match_result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("match_result")]
#endif
        public string MatchResult { get; set; }

        /// <summary>
        /// ID of the payout method.
        /// </summary>
        [JsonProperty("payout_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_method")]
#endif
        public string PayoutMethod { get; set; }

        /// <summary>
        /// ID of the recipient account. Required if the recipient distinct from the sender. Leave
        /// empty if the recipient and sender are the same entity (i.e. for me-to-me payouts).
        /// </summary>
        [JsonProperty("recipient")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient")]
#endif
        public string Recipient { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RecipientVerificationCreateOptions : BaseOptions
    {
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

// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditBalanceTransfer : StripeEntity<ReceivedCreditBalanceTransfer>
    {
        /// <summary>
        /// The ID of the Stripe Money Movement that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("payout_v1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_v1")]
#endif
        public string PayoutV1 { get; set; }

        /// <summary>
        /// Open Enum. The type of Stripe Money Movement that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}

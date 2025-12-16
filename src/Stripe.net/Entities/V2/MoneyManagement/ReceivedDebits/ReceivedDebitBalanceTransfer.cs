// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitBalanceTransfer : StripeEntity<ReceivedDebitBalanceTransfer>
    {
        /// <summary>
        /// Open Enum. The type of balance transfer that originated the ReceivedDebit.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The ID of the topup object that originated the ReceivedDebit.
        /// </summary>
        [JsonProperty("topup")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("topup")]
#endif
        public string Topup { get; set; }
    }
}

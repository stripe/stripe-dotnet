// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitBalanceTransfer : StripeEntity<ReceivedDebitBalanceTransfer>
    {
        /// <summary>
        /// The ID of the topup object that originated the ReceivedDebit.
        /// </summary>
        [JsonProperty("topup")]
        [STJS.JsonPropertyName("topup")]
        public string Topup { get; set; }

        /// <summary>
        /// Open Enum. The type of balance transfer that originated the ReceivedDebit.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

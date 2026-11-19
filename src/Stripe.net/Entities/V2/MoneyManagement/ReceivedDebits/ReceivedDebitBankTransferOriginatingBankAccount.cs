// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitBankTransferOriginatingBankAccount : StripeEntity<ReceivedDebitBankTransferOriginatingBankAccount>
    {
        /// <summary>
        /// Details of the originating account. Present when type is <c>aba</c>.
        /// </summary>
        [JsonProperty("aba")]
        [STJS.JsonPropertyName("aba")]
        public ReceivedDebitBankTransferOriginatingBankAccountAba Aba { get; set; }

        /// <summary>
        /// Details of the originating account. Present when type is <c>sort_code</c>.
        /// </summary>
        [JsonProperty("sort_code")]
        [STJS.JsonPropertyName("sort_code")]
        public ReceivedDebitBankTransferOriginatingBankAccountSortCode SortCode { get; set; }

        /// <summary>
        /// The credential type identifying the originating bank account.
        /// One of: <c>aba</c>, or <c>sort_code</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

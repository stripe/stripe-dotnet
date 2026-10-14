// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBankTransferOriginatingBankAccount : StripeEntity<ReceivedCreditBankTransferOriginatingBankAccount>
    {
        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>aba</c>.
        /// </summary>
        [JsonProperty("aba")]
        [STJS.JsonPropertyName("aba")]
        public ReceivedCreditBankTransferOriginatingBankAccountAba Aba { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>bre_b</c>.
        /// </summary>
        [JsonProperty("bre_b")]
        [STJS.JsonPropertyName("bre_b")]
        public ReceivedCreditBankTransferOriginatingBankAccountBreB BreB { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>clabe</c>.
        /// </summary>
        [JsonProperty("clabe")]
        [STJS.JsonPropertyName("clabe")]
        public ReceivedCreditBankTransferOriginatingBankAccountClabe Clabe { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>cpa</c>.
        /// </summary>
        [JsonProperty("cpa")]
        [STJS.JsonPropertyName("cpa")]
        public ReceivedCreditBankTransferOriginatingBankAccountCpa Cpa { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>iban</c>.
        /// </summary>
        [JsonProperty("iban")]
        [STJS.JsonPropertyName("iban")]
        public ReceivedCreditBankTransferOriginatingBankAccountIban Iban { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>nip</c>.
        /// </summary>
        [JsonProperty("nip")]
        [STJS.JsonPropertyName("nip")]
        public ReceivedCreditBankTransferOriginatingBankAccountNip Nip { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>pix</c>.
        /// </summary>
        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public ReceivedCreditBankTransferOriginatingBankAccountPix Pix { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>type</c> field value is
        /// <c>sort_code</c>.
        /// </summary>
        [JsonProperty("sort_code")]
        [STJS.JsonPropertyName("sort_code")]
        public ReceivedCreditBankTransferOriginatingBankAccountSortCode SortCode { get; set; }

        /// <summary>
        /// Open Enum. The type of bank transfer that originated this ReceivedCredit.
        /// One of: <c>aba</c>, <c>bre_b</c>, <c>clabe</c>, <c>cpa</c>, <c>iban</c>, <c>nip</c>,
        /// <c>pix</c>, or <c>sort_code</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressBankAccount : StripeEntity<FinancialAddressBankAccount>
    {
        /// <summary>
        /// ABA bank account details (US).
        /// </summary>
        [JsonProperty("aba")]
        [STJS.JsonPropertyName("aba")]
        public FinancialAddressBankAccountAba Aba { get; set; }

        [JsonProperty("clabe")]
        [STJS.JsonPropertyName("clabe")]
        public FinancialAddressBankAccountClabe Clabe { get; set; }

        /// <summary>
        /// The country of the bank account.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("cpa")]
        [STJS.JsonPropertyName("cpa")]
        public FinancialAddressBankAccountCpa Cpa { get; set; }

        /// <summary>
        /// Open Enum. The currency of the bank account.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// IBAN bank account details.
        /// </summary>
        [JsonProperty("iban")]
        [STJS.JsonPropertyName("iban")]
        public FinancialAddressBankAccountIban Iban { get; set; }

        /// <summary>
        /// Sort code bank account details (UK).
        /// </summary>
        [JsonProperty("sort_code")]
        [STJS.JsonPropertyName("sort_code")]
        public FinancialAddressBankAccountSortCode SortCode { get; set; }

        /// <summary>
        /// Open Enum. The type of bank account details.
        /// One of: <c>aba</c>, <c>clabe</c>, <c>cpa</c>, <c>iban</c>, or <c>sort_code</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

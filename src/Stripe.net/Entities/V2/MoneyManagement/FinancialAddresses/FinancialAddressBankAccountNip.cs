// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressBankAccountNip : StripeEntity<FinancialAddressBankAccountNip>
    {
        /// <summary>
        /// The name of the account holder.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The NIP bank code.
        /// </summary>
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The NUBAN account number.
        /// </summary>
        [JsonProperty("nuban")]
        [STJS.JsonPropertyName("nuban")]
        public string Nuban { get; set; }
    }
}

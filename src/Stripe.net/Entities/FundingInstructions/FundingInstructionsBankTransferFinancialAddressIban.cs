// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingInstructionsBankTransferFinancialAddressIban : StripeEntity<FundingInstructionsBankTransferFinancialAddressIban>
    {
        [JsonProperty("account_holder_address")]
        [STJS.JsonPropertyName("account_holder_address")]
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonProperty("bank_address")]
        [STJS.JsonPropertyName("bank_address")]
        public Address BankAddress { get; set; }

        /// <summary>
        /// The BIC/SWIFT code of the account.
        /// </summary>
        [JsonProperty("bic")]
        [STJS.JsonPropertyName("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The IBAN of the account.
        /// </summary>
        [JsonProperty("iban")]
        [STJS.JsonPropertyName("iban")]
        public string Iban { get; set; }
    }
}

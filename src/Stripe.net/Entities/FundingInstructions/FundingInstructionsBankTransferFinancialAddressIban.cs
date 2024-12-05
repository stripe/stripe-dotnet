// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddressIban : StripeEntity<FundingInstructionsBankTransferFinancialAddressIban>
    {
        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The BIC/SWIFT code of the account.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The IBAN of the account.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

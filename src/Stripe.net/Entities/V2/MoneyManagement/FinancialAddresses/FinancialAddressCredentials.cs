// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCredentials : StripeEntity<FinancialAddressCredentials>
    {
        /// <summary>
        /// Open Enum. The type of Credentials that are provisioned for the FinancialAddress.
        /// One of: <c>gb_bank_account</c>, <c>sepa_bank_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The credentials of the UK Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the sort code, account number, etc. of a UK bank account.
        /// </summary>
        [JsonProperty("gb_bank_account")]
        [STJS.JsonPropertyName("gb_bank_account")]
        public FinancialAddressCredentialsGbBankAccount GbBankAccount { get; set; }

        /// <summary>
        /// The credentials of the SEPA Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the IBAN, BIC, etc. of a SEPA bank account.
        /// </summary>
        [JsonProperty("sepa_bank_account")]
        [STJS.JsonPropertyName("sepa_bank_account")]
        public FinancialAddressCredentialsSepaBankAccount SepaBankAccount { get; set; }

        /// <summary>
        /// The credentials of the US Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the routing number, account number, etc. of a US bank account.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public FinancialAddressCredentialsUsBankAccount UsBankAccount { get; set; }
    }
}

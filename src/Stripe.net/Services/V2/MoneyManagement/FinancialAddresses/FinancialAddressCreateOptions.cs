// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the FinancialAccount the new FinancialAddress should be associated with.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Optional SEPA Bank account options, used to configure the type of SEPA Bank account to
        /// create, such as the originating country.
        /// </summary>
        [JsonProperty("sepa_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_bank_account")]
#endif
        public FinancialAddressCreateSepaBankAccountOptions SepaBankAccount { get; set; }

        /// <summary>
        /// The type of FinancialAddress details to provision.
        /// One of: <c>gb_bank_account</c>, <c>sepa_bank_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}

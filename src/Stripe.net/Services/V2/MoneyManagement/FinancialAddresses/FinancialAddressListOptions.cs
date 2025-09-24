// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressListOptions : V2.ListOptions
    {
        /// <summary>
        /// The ID of the FinancialAccount for which FinancialAddresses are to be returned.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Open Enum. A list of fields to reveal in the FinancialAddresses returned.
        /// One of: <c>credentials.gb_bank_account.account_number</c>,
        /// <c>credentials.sepa_bank_account.iban</c>, or
        /// <c>credentials.us_bank_account.account_number</c>.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif
        public List<string> Include { get; set; }
    }
}

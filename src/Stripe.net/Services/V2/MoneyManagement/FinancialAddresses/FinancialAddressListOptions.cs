// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAddressListOptions : V2.ListOptions
    {
        /// <summary>
        /// The ID of the FinancialAccount for which FinancialAddresses are to be returned.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Open Enum. A list of fields to reveal in the FinancialAddresses returned.
        /// One of: <c>credentials.gb_bank_account.account_number</c>,
        /// <c>credentials.sepa_bank_account.iban</c>, or
        /// <c>credentials.us_bank_account.account_number</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }
    }
}

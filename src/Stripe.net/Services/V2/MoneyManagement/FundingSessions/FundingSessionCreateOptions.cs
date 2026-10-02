// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FundingSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Account that owns the FinancialAccount. Required.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The ID of the FinancialAccount to fund. Required.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Per-type options used when creating the FinancialAddress. Required.
        /// </summary>
        [JsonProperty("financial_address_options")]
        [STJS.JsonPropertyName("financial_address_options")]
        public FundingSessionCreateFinancialAddressOptionsOptions FinancialAddressOptions { get; set; }

        /// <summary>
        /// Open Enum. The types of FinancialAddress that can be funded in this session. At least
        /// one is required.
        /// One of: <c>bank_account</c>, or <c>crypto_wallet</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("financial_address_types")]
        [STJS.JsonPropertyName("financial_address_types")]
        public List<string> FinancialAddressTypes { get; set; }

        /// <summary>
        /// The URL the customer is redirected to after completing or abandoning the funding
        /// session. Required.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}

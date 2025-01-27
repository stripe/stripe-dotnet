// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountForwardingSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The financial_account id.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The payment_method or bank account id. This needs to be a verified bank account.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The type of the bank account provided. This can be either "financial_account" or
        /// "payment_method".
        /// One of: <c>financial_account</c>, or <c>payment_method</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

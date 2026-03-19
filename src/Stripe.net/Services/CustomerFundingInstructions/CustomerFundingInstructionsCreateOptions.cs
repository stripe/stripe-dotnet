// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerFundingInstructionsCreateOptions : BaseOptions
    {
        /// <summary>
        /// Additional parameters for <c>bank_transfer</c> funding types.
        /// </summary>
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public CustomerFundingInstructionsBankTransferOptions BankTransfer { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The <c>funding_type</c> to get the instructions for.
        /// </summary>
        [JsonProperty("funding_type")]
        [STJS.JsonPropertyName("funding_type")]
        public string FundingType { get; set; }
    }
}

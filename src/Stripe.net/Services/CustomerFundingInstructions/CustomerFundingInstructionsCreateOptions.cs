// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerFundingInstructionsCreateOptions : BaseOptions
    {
        /// <summary>
        /// Additional parameters for <c>bank_transfer</c> funding types.
        /// </summary>
        [JsonProperty("bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transfer")]
#endif

        public CustomerFundingInstructionsBankTransferOptions BankTransfer { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// The <c>funding_type</c> to get the instructions for.
        /// </summary>
        [JsonProperty("funding_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding_type")]
#endif

        public string FundingType { get; set; }
    }
}

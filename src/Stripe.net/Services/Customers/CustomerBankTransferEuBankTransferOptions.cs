namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use CustomerFundingInstructionsBankTransferEuBankTransferOptions instead.")]
    public class CustomerBankTransferEuBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// The desired country code of the bank account information. Permitted values include:
        /// <c>BE</c>, <c>DE</c>, <c>ES</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}

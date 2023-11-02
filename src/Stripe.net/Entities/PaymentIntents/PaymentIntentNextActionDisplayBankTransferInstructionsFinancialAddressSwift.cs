// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSwift : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSwift>
    {
        /// <summary>
        /// The account number.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The bank name.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The SWIFT code.
        /// </summary>
        [JsonProperty("swift_code")]
        public string SwiftCode { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddress : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddress>
    {
        /// <summary>
        /// ABA Records contain U.S. bank account details per the ABA format.
        /// </summary>
        [JsonProperty("aba")]
        public PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressAba Aba { get; set; }

        /// <summary>
        /// Iban Records contain E.U. bank account details per the SEPA format.
        /// </summary>
        [JsonProperty("iban")]
        public PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressIban Iban { get; set; }

        /// <summary>
        /// Sort Code Records contain U.K. bank account details per the sort code format.
        /// </summary>
        [JsonProperty("sort_code")]
        public PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSortCode SortCode { get; set; }

        /// <summary>
        /// SPEI Records contain Mexico bank account details per the SPEI format.
        /// </summary>
        [JsonProperty("spei")]
        public PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSpei Spei { get; set; }

        /// <summary>
        /// The payment networks supported by this FinancialAddress.
        /// One of: <c>ach</c>, <c>bacs</c>, <c>domestic_wire_us</c>, <c>fps</c>, <c>sepa</c>,
        /// <c>spei</c>, <c>swift</c>, or <c>zengin</c>.
        /// </summary>
        [JsonProperty("supported_networks")]
        public List<string> SupportedNetworks { get; set; }

        /// <summary>
        /// SWIFT Records contain U.S. bank account details per the SWIFT format.
        /// </summary>
        [JsonProperty("swift")]
        public PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSwift Swift { get; set; }

        /// <summary>
        /// The type of financial address.
        /// One of: <c>aba</c>, <c>iban</c>, <c>sort_code</c>, <c>spei</c>, <c>swift</c>, or
        /// <c>zengin</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Zengin Records contain Japan bank account details per the Zengin format.
        /// </summary>
        [JsonProperty("zengin")]
        public PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressZengin Zengin { get; set; }
    }
}

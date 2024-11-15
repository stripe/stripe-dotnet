// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionDisplayBankTransferInstructions : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructions>
    {
        /// <summary>
        /// The remaining amount that needs to be transferred to complete the payment.
        /// </summary>
        [JsonProperty("amount_remaining")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_remaining")]
#endif

        public long? AmountRemaining { get; set; }

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
        /// A list of financial addresses that can be used to fund the customer balance.
        /// </summary>
        [JsonProperty("financial_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_addresses")]
#endif

        public List<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddress> FinancialAddresses { get; set; }

        /// <summary>
        /// A link to a hosted page that guides your customer through completing the transfer.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_instructions_url")]
#endif

        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// A string identifying this payment. Instruct your customer to include this code in the
        /// reference or memo field of their bank transfer.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif

        public string Reference { get; set; }

        /// <summary>
        /// Type of bank transfer.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}

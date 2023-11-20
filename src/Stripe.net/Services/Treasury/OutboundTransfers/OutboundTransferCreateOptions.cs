// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OutboundTransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount (in cents) to be transferred.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The PaymentMethod to use as the payment instrument for the OutboundTransfer.
        /// </summary>
        [JsonProperty("destination_payment_method")]
        public string DestinationPaymentMethod { get; set; }

        /// <summary>
        /// Hash describing payment method configuration details.
        /// </summary>
        [JsonProperty("destination_payment_method_options")]
        public OutboundTransferDestinationPaymentMethodOptionsOptions DestinationPaymentMethodOptions { get; set; }

        /// <summary>
        /// The FinancialAccount to pull funds from.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Statement descriptor to be shown on the receiving end of an OutboundTransfer. Maximum 10
        /// characters for <c>ach</c> transfers or 140 characters for <c>us_domestic_wire</c>
        /// transfers. The default value is "transfer".
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}

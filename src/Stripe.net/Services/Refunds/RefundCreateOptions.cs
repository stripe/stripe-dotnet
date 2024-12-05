// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RefundCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The identifier of the charge to refund.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Customer whose customer balance to refund from.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// For payment methods without native refund support (e.g., Konbini, PromptPay), use this
        /// email from the customer to receive refund instructions.
        /// </summary>
        [JsonProperty("instructions_email")]
        public string InstructionsEmail { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Origin of the refund.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// The identifier of the PaymentIntent to refund.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// String indicating the reason for the refund. If set, possible values are
        /// <c>duplicate</c>, <c>fraudulent</c>, and <c>requested_by_customer</c>. If you believe
        /// the charge to be fraudulent, specifying <c>fraudulent</c> as the reason will add the
        /// associated card and email to your <a href="https://stripe.com/docs/radar/lists">block
        /// lists</a>, and will also help us improve our fraud detection algorithms.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, or <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Boolean indicating whether the application fee should be refunded when refunding this
        /// charge. If a full charge refund is given, the full application fee will be refunded.
        /// Otherwise, the application fee will be refunded in an amount proportional to the amount
        /// of the charge refunded. An application fee can be refunded only by the application that
        /// created the charge.
        /// </summary>
        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        /// <summary>
        /// Boolean indicating whether the transfer should be reversed when refunding this charge.
        /// The transfer will be reversed proportionally to the amount being refunded (either the
        /// entire or partial amount).<br/><br/>A transfer can be reversed only by the application
        /// that created the charge.
        /// </summary>
        [JsonProperty("reverse_transfer")]
        public bool? ReverseTransfer { get; set; }
    }
}

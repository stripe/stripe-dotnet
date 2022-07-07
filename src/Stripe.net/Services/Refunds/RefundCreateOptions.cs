// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RefundCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer representing how much to refund.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

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
        /// Address to send refund email, use customer email if not specified.
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

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        [JsonProperty("reverse_transfer")]
        public bool? ReverseTransfer { get; set; }
    }
}

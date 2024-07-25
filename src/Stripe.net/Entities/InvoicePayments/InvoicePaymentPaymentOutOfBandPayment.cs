// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoicePaymentPaymentOutOfBandPayment : StripeEntity<InvoicePaymentPaymentOutOfBandPayment>, IHasMetadata
    {
        /// <summary>
        /// Amount paid on this out of band payment, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The type of money movement for this out of band payment record.
        /// </summary>
        [JsonProperty("money_movement_type")]
        public string MoneyMovementType { get; set; }

        /// <summary>
        /// The timestamp when this out of band payment was paid.
        /// </summary>
        [JsonProperty("paid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// The reference for this out of band payment record.
        /// </summary>
        [JsonProperty("payment_reference")]
        public string PaymentReference { get; set; }
    }
}

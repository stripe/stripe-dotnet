namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePayOptions : BaseOptions
    {
        [JsonProperty("forgive")]
        public bool? Forgive { get; set; }

        /// <summary>
        /// Indicates if a customer is on session while an invoice payment is attempted.
        /// </summary>
        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// Boolean representing whether an invoice is paid outside of Stripe. This will result in
        /// no charge being made.
        /// </summary>
        [JsonProperty("paid_out_of_band")]
        public bool? PaidOutOfBand { get; set; }

        /// <summary>
        /// ID of the payment method to use for paying the invoice.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// A payment source to be charged. The source must be the ID of a source belonging to the
        /// customer associated with the invoice being paid.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}

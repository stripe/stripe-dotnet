namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePayOptions : BaseOptions
    {
        /// <summary>
        /// In cases where the source used to pay the invoice has insufficient funds, passing
        /// <c>forgive=true</c> controls whether a charge should be attempted for the full amount
        /// available on the source, up to the amount to fully pay the invoice. This effectively
        /// forgives the difference between the amount available on the source and the amount due.
        ///
        /// Passing <c>forgive=false</c> will fail the charge if the source hasn't been pre-funded
        /// with the right amount. An example for this case is with ACH Credit Transfers and wires:
        /// if the amount wired is less than the amount due by a small amount, you might want to
        /// forgive the difference.
        /// </summary>
        [JsonProperty("forgive")]
        public bool? Forgive { get; set; }

        /// <summary>
        /// Indicates if a customer is on or off-session while an invoice payment is attempted.
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
        /// A PaymentMethod to be charged. The PaymentMethod must be the ID of a PaymentMethod
        /// belonging to the customer associated with the invoice being paid.
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

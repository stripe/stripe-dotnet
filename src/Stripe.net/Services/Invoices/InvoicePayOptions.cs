// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePayOptions : BaseOptions
    {
        private string mandate;

        /// <summary>
        /// In cases where the source used to pay the invoice has insufficient funds, passing
        /// <c>forgive=true</c> controls whether a charge should be attempted for the full amount
        /// available on the source, up to the amount to fully pay the invoice. This effectively
        /// forgives the difference between the amount available on the source and the amount due.
        ///
        /// Passing <c>forgive=false</c> will fail the charge if the source hasn't been pre-funded
        /// with the right amount. An example for this case is with ACH Credit Transfers and wires:
        /// if the amount wired is less than the amount due by a small amount, you might want to
        /// forgive the difference. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("forgive")]
        [STJS.JsonPropertyName("forgive")]
        public bool? Forgive { get; set; }

        /// <summary>
        /// ID of the mandate to be used for this invoice. It must correspond to the payment method
        /// used to pay the invoice, including the payment_method param or the invoice's
        /// default_payment_method or default_source, if set.
        /// </summary>
        [JsonProperty("mandate")]
        [STJS.JsonPropertyName("mandate")]
        public string Mandate
        {
            get => this.mandate;
            set
            {
                this.mandate = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Indicates if a customer is on or off-session while an invoice payment is attempted.
        /// Defaults to <c>true</c> (off-session).
        /// </summary>
        [JsonProperty("off_session")]
        [STJS.JsonPropertyName("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// Boolean representing whether an invoice is paid outside of Stripe. This will result in
        /// no charge being made. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("paid_out_of_band")]
        [STJS.JsonPropertyName("paid_out_of_band")]
        public bool? PaidOutOfBand { get; set; }

        /// <summary>
        /// A PaymentMethod to be charged. The PaymentMethod must be the ID of a PaymentMethod
        /// belonging to the customer associated with the invoice being paid.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// A payment source to be charged. The source must be the ID of a source belonging to the
        /// customer associated with the invoice being paid.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public string Source { get; set; }
    }
}

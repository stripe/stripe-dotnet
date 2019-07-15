namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoicePayOptions : BaseOptions
    {
        [JsonProperty("forgive")]
        public bool? Forgive { get; set; }

        /// <summary>
        /// Boolean representing whether an invoice is paid outside of Stripe. This will result in
        /// no charge being made.
        /// </summary>
        [JsonProperty("paid_out_of_band")]
        public bool? PaidOutOfBand { get; set; }

        /// <summary>
        /// Indicates if a customer is on session while an invoice payment is attempted.
        /// </summary>
        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// ID of the payment method to use for paying the invoice.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }
    }
}

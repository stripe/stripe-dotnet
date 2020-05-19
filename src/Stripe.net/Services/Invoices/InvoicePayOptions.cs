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

        [JsonProperty("paid_out_of_band")]
        public bool? PaidOutOfBand { get; set; }

        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}

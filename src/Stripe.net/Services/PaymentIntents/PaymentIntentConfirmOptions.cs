namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }
    }
}

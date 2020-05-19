namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("error_on_requires_action")]
        public bool? ErrorOnRequiresAction { get; set; }

        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        [JsonProperty("mandate_data")]
        public PaymentIntentMandateDataOptions MandateData { get; set; }

        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_data")]
        public PaymentIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        [JsonProperty("payment_method_options")]
        public PaymentIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}

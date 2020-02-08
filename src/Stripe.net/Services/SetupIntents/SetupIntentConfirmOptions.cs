namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentConfirmOptions : BaseOptions
    {
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("mandate_data")]
        public SetupIntentMandateDataOptions MandateData { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}

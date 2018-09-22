namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentCreateOptions : PaymentIntentSharedOptions
    {
        [JsonProperty("allowed_source_types")]
        public List<string> AllowedSourceTypes { get; set; }

        [JsonProperty("attempt_confirmation")]
        public bool? AttemptConfirmation { get; set; }

        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        [JsonProperty("shipping")]
        public StripeChargeShippingOptions Shipping { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}

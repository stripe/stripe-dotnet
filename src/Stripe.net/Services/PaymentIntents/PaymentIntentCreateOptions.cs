namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PaymentIntentCreateOptions : PaymentIntentSharedOptions
    {
        [FormProperty("allowed_source_types")]
        public List<string> AllowedSourceTypes { get; set; }

        [FormProperty("attempt_confirmation")]
        public bool? AttemptConfirmation { get; set; }

        [FormProperty("capture_method")]
        public string CaptureMethod { get; set; }

        [FormProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        [FormProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}

namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CardholderSharedOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("billing")]
        public BillingOptions Billing { get; set; }

        [FormProperty("email")]
        public string Email { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("name")]
        public string Name { get; set; }

        [FormProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [FormProperty("status")]
        public string Status { get; set; }
    }
}

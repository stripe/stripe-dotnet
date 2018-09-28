namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class EvidenceOptions : INestedOptions
    {
        [FormProperty("fraudulent[dispute_explanation]")]
        public string FraudulentDisputeExplanation { get; set; }

        [FormProperty("fraudulent[uncategorized_file]")]
        public string FraudulentUncategorizedFile { get; set; }

        [FormProperty("other[dispute_explanation]")]
        public string OtherDisputeExplanation { get; set; }

        [FormProperty("other[uncategorized_file]")]
        public string OtherUncategorizedFile { get; set; }
    }
}

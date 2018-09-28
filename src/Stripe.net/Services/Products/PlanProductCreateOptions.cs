namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PlanProductCreateOptions : INestedOptions, ISupportMetadata
    {
        [FormProperty("id")]
        public string Id { get; set; }

        [FormProperty("name")]
        public string Name { get; set; }

        [FormProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}

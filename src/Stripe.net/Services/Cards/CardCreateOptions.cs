namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CardCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("source")]
        public string SourceToken { get; set; }

        [FormProperty("source")]
        public CardCreateNestedOptions SourceCard { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }
    }
}

namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ExternalAccountUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [FormProperty("external_account")]
        public ExternalAccountCardUpdateOptions ExternalAccountCard { get; set; }
    }
}

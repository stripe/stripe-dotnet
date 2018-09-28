namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class BankAccountUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [FormProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}

namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ExternalAccountCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("external_account")]
        public string ExternalAccountTokenId { get; set; }

        [FormProperty("external_account")]
        public AccountBankAccountOptions ExternalAccountBankAccount { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }
    }
}

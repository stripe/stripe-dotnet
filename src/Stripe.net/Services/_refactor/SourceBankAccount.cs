namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class SourceBankAccount : INestedOptions, ISupportMetadata
    {
        [FormProperty("object")]
        internal string Object => "bank_account";

        [FormProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [FormProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [FormProperty("account_number")]
        public string AccountNumber { get; set; }

        [FormProperty("bank_name")]
        public string BankName { get; set; }

        [FormProperty("country")]
        public string Country { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}

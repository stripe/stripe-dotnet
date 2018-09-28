namespace Stripe
{
    using System;
    using Stripe.Infrastructure;

    public class AccountBankAccountOptions : INestedOptions
    {
        [FormProperty("object")]
        internal string Object => "bank_account";

        [FormProperty("account_number")]
        public string AccountNumber { get; set; }

        [FormProperty("country")]
        public string Country { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [FormProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [FormProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}

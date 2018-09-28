namespace Stripe
{
    using Stripe.Infrastructure;

    public class BankAccountOptions : INestedOptions
    {
        [FormProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [FormProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [FormProperty("account_number")]
        public string AccountNumber { get; set; }

        [FormProperty("country")]
        public string Country { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}

namespace Stripe
{
    public enum SourceType
    {
        Card,
        BankAccount
    }

    public class Source : StripeObject
    {
        public SourceType Type { get; set; }

        public StripeCard Card { get; set; }
        public StripeBankAccount BankAccount { get; set; }
    }
}

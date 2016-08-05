namespace Stripe
{
    public enum SourceType
    {
        Card,
        BankAccount
    }

    public class Source
    {
        public SourceType Type { get; set; }
        public string Id { get; set; }

        public StripeCard Card { get; set; }
        public StripeBankAccount BankAccount { get; set; }
    }
}

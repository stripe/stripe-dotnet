namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum ExternalAccountType
    {
        Card,
        BankAccount
    }

    [JsonConverter(typeof(ExternalAccountConverter))]
    public class ExternalAccount : StripeEntityWithId
    {
        public ExternalAccountType Type { get; set; }

        public Card Card { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}

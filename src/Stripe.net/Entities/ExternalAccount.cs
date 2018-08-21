namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum ExternalAccountType
    {
        Card,
        BankAccount,
        Deleted
    }

    [JsonConverter(typeof(ExternalAccountConverter))]
    public class ExternalAccount : StripeEntityWithId
    {
        public ExternalAccountType Type { get; set; }

        public StripeDeleted Deleted { get; set; }

        public StripeCard Card { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}

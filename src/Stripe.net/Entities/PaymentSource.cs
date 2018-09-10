namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum PaymentSourceType
    {
        Account,
        BankAccount,
        Card,
        Deleted,
        Source,
    }

    [JsonConverter(typeof(PaymentSourceConverter))]
    public class PaymentSource : StripeEntityWithId
    {
        public PaymentSourceType Type { get; set; }

        public StripeAccount Account { get; set; }

        public BankAccount BankAccount { get; set; }

        public StripeCard Card { get; set; }

        public StripeDeleted Deleted { get; set; }

        public StripeSource SourceObject { get; set; }
    }
}

using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public enum SourceType
    {
        Account,
        BankAccount,
        Card,
        Deleted,
        Source,
    }

    [JsonConverter(typeof(SourceConverter))]
    public class Source : StripeEntityWithId
    {
        public SourceType Type { get; set; }

        public StripeAccount Account { get; set; }
        public StripeBankAccount BankAccount { get; set; }
        public StripeCard Card { get; set; }
        public StripeDeleted Deleted { get; set; }
        public StripeSource SourceObject { get; set; }
    }
}

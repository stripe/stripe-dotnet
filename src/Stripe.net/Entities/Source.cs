using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public enum SourceType
    {
        Account,
        Card,
        BankAccount,
        Deleted
    }

    [JsonConverter(typeof(SourceConverter))]
    public class Source : StripeEntityWithId
    {
        public SourceType Type { get; set; }

        public StripeAccount Account { get; set; }
        public StripeDeleted Deleted { get; set; }
        public StripeCard Card { get; set; }
        public StripeBankAccount BankAccount { get; set; }
    }
}

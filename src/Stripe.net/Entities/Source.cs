using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public enum SourceType
    {
        Card,
        BankAccount
    }

    [JsonConverter(typeof(SourceConverter))]
    public class Source : StripeEntityWithId
    {
        public SourceType Type { get; set; }

        public StripeCard Card { get; set; }
        public StripeBankAccount BankAccount { get; set; }
    }
}

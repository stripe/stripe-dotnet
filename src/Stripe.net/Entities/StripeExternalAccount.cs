using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public enum StripeExternalAccountType
    {
        Card,
        BankAccount
    }

    [JsonConverter(typeof(StripeExternalAccountConverter))]
    public class StripeExternalAccount : StripeEntityWithId
    {
        public StripeExternalAccountType Type { get; set; }

        public StripeCard Card { get; set; }
        public StripeBankAccount BankAccount { get; set; }
    }
}

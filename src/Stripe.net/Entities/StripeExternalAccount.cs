using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public enum ExternalAccountType
    {
        Card,
        BankAccount,
        Deleted
    }

    [JsonConverter(typeof(ExternalAccountConverter))]
    public class StripeExternalAccount : StripeEntityWithId
    {
        public ExternalAccountType Type { get; set; }

        public StripeDeleted Deleted { get; set; }
        public StripeCard Card { get; set; }
        public StripeBankAccount BankAccount { get; set; }
    }
}

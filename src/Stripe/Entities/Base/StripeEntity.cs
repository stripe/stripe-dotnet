using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeEntity
    {
        public string StripeRawJson { get; set; }
    }
}
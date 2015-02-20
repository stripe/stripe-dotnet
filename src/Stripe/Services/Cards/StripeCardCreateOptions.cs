using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCardCreateOptions
    {
        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }
    }
}

namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsSofortOptions : INestedOptions
    {
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}

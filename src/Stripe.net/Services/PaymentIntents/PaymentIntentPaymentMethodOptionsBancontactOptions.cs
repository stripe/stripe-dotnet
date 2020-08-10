namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBancontactOptions : INestedOptions
    {
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}

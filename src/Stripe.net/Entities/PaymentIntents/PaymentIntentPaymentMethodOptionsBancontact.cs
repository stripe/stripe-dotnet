namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBancontact : StripeEntity<PaymentIntentPaymentMethodOptionsBancontact>
    {
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}

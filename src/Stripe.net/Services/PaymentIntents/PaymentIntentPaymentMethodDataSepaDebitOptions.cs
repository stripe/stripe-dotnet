namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataSepaDebitOptions : INestedOptions
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

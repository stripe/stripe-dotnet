namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodSepaDebitCreateOptions : INestedOptions
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

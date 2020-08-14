namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodSepaDebitOptions : INestedOptions
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodSepaDebitCreateOptions : INestedOptions
    {
        /// <summary>
        /// Card security code. It is highly recommended to always include this value.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodSepaDebitCreateOptions : INestedOptions
    {
        /// <summary>
        /// IBAN associated with this payment method. This only works on creation.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

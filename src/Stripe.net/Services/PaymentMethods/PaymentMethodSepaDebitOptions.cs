namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// IBAN of the bank account.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

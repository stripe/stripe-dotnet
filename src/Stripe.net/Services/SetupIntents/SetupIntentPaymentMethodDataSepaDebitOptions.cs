// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodDataSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// IBAN of the bank account.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfirmationTokenPaymentMethodDataSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// IBAN of the bank account.
        /// </summary>
        [JsonProperty("iban")]
        [STJS.JsonPropertyName("iban")]
        public string Iban { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodDataSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// IBAN of the bank account.
        /// </summary>
        [JsonProperty("iban")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban")]
#endif
        public string Iban { get; set; }
    }
}

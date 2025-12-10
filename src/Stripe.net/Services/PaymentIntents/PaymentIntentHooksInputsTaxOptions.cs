// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentHooksInputsTaxOptions : INestedOptions
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/api/tax/calculations">TaxCalculation</a> id.
        /// </summary>
        [JsonProperty("calculation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("calculation")]
#endif
        public string Calculation { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentHooksInputsTaxOptions : INestedOptions
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/api/tax/calculations">TaxCalculation</a> id.
        /// </summary>
        [JsonProperty("calculation")]
        [STJS.JsonPropertyName("calculation")]
        public string Calculation { get; set; }
    }
}

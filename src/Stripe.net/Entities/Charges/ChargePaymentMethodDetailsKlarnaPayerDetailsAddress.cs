// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsKlarnaPayerDetailsAddress : StripeEntity<ChargePaymentMethodDetailsKlarnaPayerDetailsAddress>
    {
        /// <summary>
        /// The payer address country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}

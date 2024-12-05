// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsOxxo : StripeEntity<ChargePaymentMethodDetailsOxxo>
    {
        /// <summary>
        /// OXXO reference number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }
    }
}

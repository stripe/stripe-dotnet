// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsKlarnaPayerDetails : StripeEntity<ChargePaymentMethodDetailsKlarnaPayerDetails>
    {
        /// <summary>
        /// The payer's address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public ChargePaymentMethodDetailsKlarnaPayerDetailsAddress Address { get; set; }
    }
}

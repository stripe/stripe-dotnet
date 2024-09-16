// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsKlarnaPayerDetails : StripeEntity<ChargePaymentMethodDetailsKlarnaPayerDetails>
    {
        /// <summary>
        /// The payer's address.
        /// </summary>
        [JsonProperty("address")]
        public ChargePaymentMethodDetailsKlarnaPayerDetailsAddress Address { get; set; }
    }
}

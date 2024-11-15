// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsKlarnaPayerDetails : StripeEntity<ChargePaymentMethodDetailsKlarnaPayerDetails>
    {
        /// <summary>
        /// The payer's address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif

        public ChargePaymentMethodDetailsKlarnaPayerDetailsAddress Address { get; set; }
    }
}

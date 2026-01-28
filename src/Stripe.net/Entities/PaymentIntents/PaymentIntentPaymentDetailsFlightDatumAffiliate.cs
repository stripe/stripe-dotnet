// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumAffiliate : StripeEntity<PaymentIntentPaymentDetailsFlightDatumAffiliate>
    {
        /// <summary>
        /// Affiliate code.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// Affiliate name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Code provided by the company to a travel agent authorizing ticket issuance.
        /// </summary>
        [JsonProperty("travel_authorization_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("travel_authorization_code")]
#endif
        public string TravelAuthorizationCode { get; set; }
    }
}

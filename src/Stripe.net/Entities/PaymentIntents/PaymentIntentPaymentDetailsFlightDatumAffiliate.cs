// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumAffiliate : StripeEntity<PaymentIntentPaymentDetailsFlightDatumAffiliate>
    {
        /// <summary>
        /// Affiliate code.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Affiliate name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Code provided by the company to a travel agent authorizing ticket issuance.
        /// </summary>
        [JsonProperty("travel_authorization_code")]
        [STJS.JsonPropertyName("travel_authorization_code")]
        public string TravelAuthorizationCode { get; set; }
    }
}

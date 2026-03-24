// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsFlightDatumAffiliateOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate partner code.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Name of affiliate partner.
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

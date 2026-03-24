// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsFlightDatumTotalDiscountsOptions : INestedOptions
    {
        /// <summary>
        /// Corporate client discount code.
        /// </summary>
        [JsonProperty("corporate_client_code")]
        [STJS.JsonPropertyName("corporate_client_code")]
        public string CorporateClientCode { get; set; }
    }
}

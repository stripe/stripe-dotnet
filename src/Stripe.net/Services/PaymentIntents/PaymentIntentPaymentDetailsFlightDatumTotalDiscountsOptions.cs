// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumTotalDiscountsOptions : INestedOptions
    {
        /// <summary>
        /// Corporate client discount code.
        /// </summary>
        [JsonProperty("corporate_client_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("corporate_client_code")]
#endif
        public string CorporateClientCode { get; set; }
    }
}

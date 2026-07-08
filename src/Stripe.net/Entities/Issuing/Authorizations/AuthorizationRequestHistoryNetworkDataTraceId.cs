// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationRequestHistoryNetworkDataTraceId : StripeEntity<AuthorizationRequestHistoryNetworkDataTraceId>
    {
        /// <summary>
        /// The unique reference number within the specified financial network on the specified
        /// network date.
        /// </summary>
        [JsonProperty("banknet_reference_number")]
        [STJS.JsonPropertyName("banknet_reference_number")]
        public string BanknetReferenceNumber { get; set; }

        /// <summary>
        /// The identifier of the program or service.
        /// </summary>
        [JsonProperty("financial_network_code")]
        [STJS.JsonPropertyName("financial_network_code")]
        public string FinancialNetworkCode { get; set; }

        /// <summary>
        /// The card network's record date for this authorization.
        /// </summary>
        [JsonProperty("network_date")]
        [STJS.JsonPropertyName("network_date")]
        public string NetworkDate { get; set; }
    }
}

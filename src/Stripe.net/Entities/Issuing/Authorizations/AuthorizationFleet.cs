// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationFleet : StripeEntity<AuthorizationFleet>
    {
        /// <summary>
        /// Answers to prompts presented to the cardholder at the point of sale. Prompted fields
        /// vary depending on the configuration of your physical fleet cards. Typical points of sale
        /// support only numeric entry.
        /// </summary>
        [JsonProperty("cardholder_prompt_data")]
        [STJS.JsonPropertyName("cardholder_prompt_data")]
        public AuthorizationFleetCardholderPromptData CardholderPromptData { get; set; }

        /// <summary>
        /// The type of purchase.
        /// One of: <c>fuel_and_non_fuel_purchase</c>, <c>fuel_purchase</c>, or
        /// <c>non_fuel_purchase</c>.
        /// </summary>
        [JsonProperty("purchase_type")]
        [STJS.JsonPropertyName("purchase_type")]
        public string PurchaseType { get; set; }

        /// <summary>
        /// More information about the total amount. Typically this information is received from the
        /// merchant after the authorization has been approved and the fuel dispensed. This
        /// information is not guaranteed to be accurate as some merchants may provide unreliable
        /// data.
        /// </summary>
        [JsonProperty("reported_breakdown")]
        [STJS.JsonPropertyName("reported_breakdown")]
        public AuthorizationFleetReportedBreakdown ReportedBreakdown { get; set; }

        /// <summary>
        /// The type of fuel service.
        /// One of: <c>full_service</c>, <c>non_fuel_transaction</c>, or <c>self_service</c>.
        /// </summary>
        [JsonProperty("service_type")]
        [STJS.JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}

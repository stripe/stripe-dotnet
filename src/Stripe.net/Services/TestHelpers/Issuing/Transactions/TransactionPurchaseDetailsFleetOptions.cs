// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionPurchaseDetailsFleetOptions : INestedOptions
    {
        /// <summary>
        /// Answers to prompts presented to the cardholder at the point of sale. Prompted fields
        /// vary depending on the configuration of your physical fleet cards. Typical points of sale
        /// support only numeric entry.
        /// </summary>
        [JsonProperty("cardholder_prompt_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder_prompt_data")]
#endif

        public TransactionPurchaseDetailsFleetCardholderPromptDataOptions CardholderPromptData { get; set; }

        /// <summary>
        /// The type of purchase. One of <c>fuel_purchase</c>, <c>non_fuel_purchase</c>, or
        /// <c>fuel_and_non_fuel_purchase</c>.
        /// One of: <c>fuel_and_non_fuel_purchase</c>, <c>fuel_purchase</c>, or
        /// <c>non_fuel_purchase</c>.
        /// </summary>
        [JsonProperty("purchase_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_type")]
#endif

        public string PurchaseType { get; set; }

        /// <summary>
        /// More information about the total amount. This information is not guaranteed to be
        /// accurate as some merchants may provide unreliable data.
        /// </summary>
        [JsonProperty("reported_breakdown")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reported_breakdown")]
#endif

        public TransactionPurchaseDetailsFleetReportedBreakdownOptions ReportedBreakdown { get; set; }

        /// <summary>
        /// The type of fuel service. One of <c>non_fuel_transaction</c>, <c>full_service</c>, or
        /// <c>self_service</c>.
        /// One of: <c>full_service</c>, <c>non_fuel_transaction</c>, or <c>self_service</c>.
        /// </summary>
        [JsonProperty("service_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_type")]
#endif

        public string ServiceType { get; set; }
    }
}

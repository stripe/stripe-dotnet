// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractContractLineDetailOverrideServiceActionAdd : StripeEntity<ContractContractLineDetailOverrideServiceActionAdd>
    {
        /// <summary>
        /// Details for the credit grant. Required if <c>type</c> is <c>credit_grant</c>.
        /// </summary>
        [JsonProperty("credit_grant")]
        [STJS.JsonPropertyName("credit_grant")]
        public ContractContractLineDetailOverrideServiceActionAddCreditGrant CreditGrant { get; set; }

        /// <summary>
        /// The interval for assessing service.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("service_interval")]
        [STJS.JsonPropertyName("service_interval")]
        public string ServiceInterval { get; set; }

        /// <summary>
        /// The length of the interval for assessing service.
        /// </summary>
        [JsonProperty("service_interval_count")]
        [STJS.JsonPropertyName("service_interval_count")]
        public long ServiceIntervalCount { get; set; }

        /// <summary>
        /// The type of the service action.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

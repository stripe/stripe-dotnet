// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ServiceActionCreateOptions : BaseOptions
    {
        /// <summary>
        /// Details for the credit grant. Required if <c>type</c> is <c>credit_grant</c>.
        /// </summary>
        [JsonProperty("credit_grant")]
        [STJS.JsonPropertyName("credit_grant")]
        public ServiceActionCreateCreditGrantOptions CreditGrant { get; set; }

        /// <summary>
        /// Details for the credit grant per tenant. Required if <c>type</c> is
        /// <c>credit_grant_per_tenant</c>.
        /// </summary>
        [JsonProperty("credit_grant_per_tenant")]
        [STJS.JsonPropertyName("credit_grant_per_tenant")]
        public ServiceActionCreateCreditGrantPerTenantOptions CreditGrantPerTenant { get; set; }

        /// <summary>
        /// An internal key you can use to search for this service action. Maximum length of 200
        /// characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

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
        public long? ServiceIntervalCount { get; set; }

        /// <summary>
        /// The type of the service action.
        /// One of: <c>credit_grant</c>, or <c>credit_grant_per_tenant</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

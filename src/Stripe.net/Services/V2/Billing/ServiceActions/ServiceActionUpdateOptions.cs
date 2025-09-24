// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Details for the credit grant. Can only be set if the service action's <c>type</c> is
        /// <c>credit_grant</c>.
        /// </summary>
        [JsonProperty("credit_grant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_grant")]
#endif
        public ServiceActionUpdateCreditGrantOptions CreditGrant { get; set; }

        /// <summary>
        /// Details for the credit grant per tenant. Can only be set if the service action's
        /// <c>type</c> is <c>credit_grant_per_tenant</c>.
        /// </summary>
        [JsonProperty("credit_grant_per_tenant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_grant_per_tenant")]
#endif
        public ServiceActionUpdateCreditGrantPerTenantOptions CreditGrantPerTenant { get; set; }

        /// <summary>
        /// An internal key you can use to search for this service action. Maximum length of 200
        /// characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }
    }
}

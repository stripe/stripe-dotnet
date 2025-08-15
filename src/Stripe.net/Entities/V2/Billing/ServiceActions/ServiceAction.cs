// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceAction : StripeEntity<ServiceAction>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the ServiceAction.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details for the credit grant. Provided only if <c>type</c> is "credit_grant".
        /// </summary>
        [JsonProperty("credit_grant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_grant")]
#endif
        public ServiceActionCreditGrant CreditGrant { get; set; }

        /// <summary>
        /// Details for the credit grant per tenant. Provided only if <c>type</c> is
        /// "credit_grant_per_tenant".
        /// </summary>
        [JsonProperty("credit_grant_per_tenant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_grant_per_tenant")]
#endif
        public ServiceActionCreditGrantPerTenant CreditGrantPerTenant { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// An internal key you can use to search for this service action.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

        /// <summary>
        /// The interval for assessing service.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("service_interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_interval")]
#endif
        public string ServiceInterval { get; set; }

        /// <summary>
        /// The length of the interval for assessing service.
        /// </summary>
        [JsonProperty("service_interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_interval_count")]
#endif
        public long ServiceIntervalCount { get; set; }

        /// <summary>
        /// The type of the service action.
        /// One of: <c>credit_grant</c>, or <c>credit_grant_per_tenant</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}

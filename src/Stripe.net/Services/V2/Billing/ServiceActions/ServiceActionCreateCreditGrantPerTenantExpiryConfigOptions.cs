// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ServiceActionCreateCreditGrantPerTenantExpiryConfigOptions : INestedOptions
    {
        /// <summary>
        /// The type of the expiry configuration. We currently support <c>end_of_service_period</c>.
        /// One of: <c>end_of_service_period</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

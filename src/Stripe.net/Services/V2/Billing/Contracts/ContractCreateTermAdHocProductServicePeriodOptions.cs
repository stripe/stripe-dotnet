// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateTermAdHocProductServicePeriodOptions : INestedOptions
    {
        /// <summary>
        /// The finite exclusive end; must be after starts_at. Never is not supported.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractCreateTermAdHocProductServicePeriodEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The finite inclusive start of the service period.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractCreateTermAdHocProductServicePeriodStartsAtOptions StartsAt { get; set; }
    }
}

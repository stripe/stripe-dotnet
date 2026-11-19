// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateBillingGroupDataBillingSettingsTaxOptions : INestedOptions
    {
        /// <summary>
        /// Determines if tax is calculated automatically based on a product tax code or manually
        /// based on rules defined by the business. Omit to use the applicable default.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

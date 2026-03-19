// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteLineTrialSettingsEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// Configure how an opt-in following a paid trial is billed when using <c>billing_behavior:
        /// prorate_up_front</c>.
        /// One of: <c>defer</c>, or <c>include</c>.
        /// </summary>
        [JsonProperty("prorate_up_front")]
        [STJS.JsonPropertyName("prorate_up_front")]
        public string ProrateUpFront { get; set; }
    }
}

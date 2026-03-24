// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsDefaultSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Configures how the subscription schedule handles billing for phase transitions.
        /// One of: <c>billing_period_start</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("phase_effective_at")]
        [STJS.JsonPropertyName("phase_effective_at")]
        public string PhaseEffectiveAt { get; set; }
    }
}

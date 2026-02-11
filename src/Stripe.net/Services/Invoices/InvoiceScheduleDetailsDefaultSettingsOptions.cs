// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsDefaultSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Configures how the subscription schedule handles billing for phase transitions.
        /// One of: <c>billing_period_start</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("phase_effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phase_effective_at")]
#endif
        public string PhaseEffectiveAt { get; set; }
    }
}

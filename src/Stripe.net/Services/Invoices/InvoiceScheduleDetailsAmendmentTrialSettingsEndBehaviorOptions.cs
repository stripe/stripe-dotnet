// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsAmendmentTrialSettingsEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// Configure how an opt-in following a paid trial is billed when using <c>billing_behavior:
        /// prorate_up_front</c>.
        /// One of: <c>defer</c>, or <c>include</c>.
        /// </summary>
        [JsonProperty("prorate_up_front")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prorate_up_front")]
#endif
        public string ProrateUpFront { get; set; }
    }
}

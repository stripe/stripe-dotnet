// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsPhaseTrialSettingsEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// Configure how an opt-in following a paid trial is billed when using <c>billing_behavior:
        /// prorate_up_front</c>.
        /// One of: <c>defer</c>, or <c>include</c>.
        /// </summary>
        [JsonProperty("prorate_up_front")]
        public string ProrateUpFront { get; set; }
    }
}

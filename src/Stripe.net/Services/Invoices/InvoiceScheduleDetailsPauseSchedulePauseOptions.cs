// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsPauseSchedulePauseOptions : INestedOptions
    {
        /// <summary>
        /// When to pause the subscription.
        /// </summary>
        [JsonProperty("pause_at")]
        [STJS.JsonPropertyName("pause_at")]
        public InvoiceScheduleDetailsPauseSchedulePausePauseAtOptions PauseAt { get; set; }

        /// <summary>
        /// Settings controlling billing behavior during the pause.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public InvoiceScheduleDetailsPauseSchedulePauseSettingsOptions Settings { get; set; }
    }
}

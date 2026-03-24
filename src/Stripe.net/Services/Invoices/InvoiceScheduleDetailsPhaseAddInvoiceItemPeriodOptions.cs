// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsPhaseAddInvoiceItemPeriodOptions : INestedOptions
    {
        /// <summary>
        /// End of the invoice item period.
        /// </summary>
        [JsonProperty("end")]
        [STJS.JsonPropertyName("end")]
        public InvoiceScheduleDetailsPhaseAddInvoiceItemPeriodEndOptions End { get; set; }

        /// <summary>
        /// Start of the invoice item period.
        /// </summary>
        [JsonProperty("start")]
        [STJS.JsonPropertyName("start")]
        public InvoiceScheduleDetailsPhaseAddInvoiceItemPeriodStartOptions Start { get; set; }
    }
}

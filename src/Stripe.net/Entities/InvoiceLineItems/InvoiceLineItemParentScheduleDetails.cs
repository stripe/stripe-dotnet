// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParentScheduleDetails : StripeEntity<InvoiceLineItemParentScheduleDetails>
    {
        /// <summary>
        /// The subscription schedule that generated this line item.
        /// </summary>
        [JsonProperty("schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule")]
#endif
        public string Schedule { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemParentScheduleDetails : StripeEntity<InvoiceItemParentScheduleDetails>
    {
        /// <summary>
        /// The subscription schedule that generated this invoice item.
        /// </summary>
        [JsonProperty("schedule")]
        [STJS.JsonPropertyName("schedule")]
        public string Schedule { get; set; }
    }
}

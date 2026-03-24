// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsAmendmentSetPauseCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the pause_collection behavior to apply to the amendment.
        /// </summary>
        [JsonProperty("set")]
        [STJS.JsonPropertyName("set")]
        public InvoiceScheduleDetailsAmendmentSetPauseCollectionSetOptions Set { get; set; }

        /// <summary>
        /// Determines the type of the pause_collection amendment.
        /// One of: <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

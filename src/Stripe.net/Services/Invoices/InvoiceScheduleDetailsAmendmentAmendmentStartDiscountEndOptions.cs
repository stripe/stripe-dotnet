// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsAmendmentAmendmentStartDiscountEndOptions : INestedOptions
    {
        /// <summary>
        /// The ID of a specific discount.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public string Discount { get; set; }
    }
}

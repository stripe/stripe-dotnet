// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsAmendmentAmendmentStartAmendmentEndOptions : INestedOptions
    {
        /// <summary>
        /// The position of the previous amendment in the <c>amendments</c> array after which this
        /// amendment should begin. Indexes start from 0 and must be less than the index of the
        /// current amendment in the array.
        /// </summary>
        [JsonProperty("index")]
        [STJS.JsonPropertyName("index")]
        public long? Index { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsAmendmentAmendmentStartAmendmentEndOptions : INestedOptions
    {
        /// <summary>
        /// The position of the previous amendment in the <c>amendments</c> array after which this
        /// amendment should begin. Indexes start from 0 and must be less than the index of the
        /// current amendment in the array.
        /// </summary>
        [JsonProperty("index")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("index")]
#endif
        public long? Index { get; set; }
    }
}

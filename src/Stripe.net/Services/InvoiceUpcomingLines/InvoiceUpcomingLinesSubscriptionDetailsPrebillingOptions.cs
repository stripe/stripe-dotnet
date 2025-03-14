// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpcomingLinesSubscriptionDetailsPrebillingOptions : INestedOptions
    {
        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iterations")]
#endif
        public long? Iterations { get; set; }
    }
}

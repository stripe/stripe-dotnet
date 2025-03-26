// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Select Issuing disputes with the given status.
        /// One of: <c>expired</c>, <c>lost</c>, <c>submitted</c>, <c>unsubmitted</c>, or
        /// <c>won</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Select the Issuing dispute for the given transaction.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif
        public string Transaction { get; set; }
    }
}

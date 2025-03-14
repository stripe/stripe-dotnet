// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingOfferListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// limit list to offers belonging to given connected account.
        /// </summary>
        [JsonProperty("connected_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("connected_account")]
#endif
        public string ConnectedAccount { get; set; }

        /// <summary>
        /// limit list to offers with given status.
        /// One of: <c>accepted</c>, <c>canceled</c>, <c>completed</c>, <c>delivered</c>,
        /// <c>expired</c>, <c>fully_repaid</c>, <c>paid_out</c>, <c>rejected</c>, <c>revoked</c>,
        /// or <c>undelivered</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}

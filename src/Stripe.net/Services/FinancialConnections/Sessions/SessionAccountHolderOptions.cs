// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionAccountHolderOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose accounts you will retrieve. Only available when
        /// <c>type</c> is <c>account</c>.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Stripe customer whose accounts you will retrieve. Only available when
        /// <c>type</c> is <c>customer</c>.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The ID of Account representing a customer whose accounts you will retrieve. Only
        /// available when <c>type</c> is <c>customer</c>.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Type of account holder to collect accounts for.
        /// One of: <c>account</c>, or <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionAccountHolderOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose accounts you will retrieve. Only available when
        /// <c>type</c> is <c>account</c>.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Stripe customer whose accounts you will retrieve. Only available when
        /// <c>type</c> is <c>customer</c>.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of Account representing a customer whose accounts you will retrieve. Only
        /// available when <c>type</c> is <c>customer</c>.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Type of account holder to collect accounts for.
        /// One of: <c>account</c>, or <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

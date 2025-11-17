// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceTransferDestinationBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Destination balance type to push funds into for the Balance Transfer.
        /// One of: <c>issuing</c>, or <c>payments</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}

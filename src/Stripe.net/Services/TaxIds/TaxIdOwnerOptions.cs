// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdOwnerOptions : INestedOptions
    {
        /// <summary>
        /// Account the tax ID belongs to. Required when <c>type=account</c>.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Customer the tax ID belongs to. Required when <c>type=customer</c>.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Type of owner referenced.
        /// One of: <c>account</c>, <c>application</c>, <c>customer</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

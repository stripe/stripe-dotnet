// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TaxIdOwnerOptions : INestedOptions
    {
        /// <summary>
        /// Connected Account the tax ID belongs to. Required when <c>type=account</c>.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Customer the tax ID belongs to. Required when <c>type=customer</c>.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// ID of the Account representing the customer that the tax ID belongs to. Can be used in
        /// place of <c>customer</c> when <c>type=customer</c>.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Type of owner referenced.
        /// One of: <c>account</c>, <c>application</c>, <c>customer</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

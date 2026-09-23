// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConsentAccountHolderOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Account for whom the Consent is issued. Required when <c>type</c> is
        /// <c>account</c>.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Customer for whom the Consent is issued. Required when <c>type</c> is
        /// <c>customer</c> unless <c>customer_account</c> is provided.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of an Account representing the Customer for whom the Consent is issued. Required
        /// when <c>type</c> is <c>customer</c> unless <c>customer</c> is provided.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The type of account holder for whom the Consent is issued.
        /// One of: <c>account</c>, or <c>customer</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

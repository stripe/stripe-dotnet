// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceSubscriptionDetailsPrebillingOptions : INestedOptions
    {
        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public long? Iterations { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OperationsResolveAddressResultPrecisionDetailsIssue : StripeEntity<OperationsResolveAddressResultPrecisionDetailsIssue>
    {
        /// <summary>
        /// A code describing the issue.
        /// One of: <c>required_for_improved_precision</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The address field with the issue.
        /// One of: <c>city</c>, <c>country</c>, <c>line1</c>, <c>postal_code</c>, or <c>state</c>.
        /// </summary>
        [JsonProperty("field")]
        [STJS.JsonPropertyName("field")]
        public string Field { get; set; }
    }
}

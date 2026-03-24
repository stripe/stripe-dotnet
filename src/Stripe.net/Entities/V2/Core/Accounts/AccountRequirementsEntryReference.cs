// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRequirementsEntryReference : StripeEntity<AccountRequirementsEntryReference>
    {
        /// <summary>
        /// If <c>inquiry</c> is the type, the inquiry token.
        /// </summary>
        [JsonProperty("inquiry")]
        [STJS.JsonPropertyName("inquiry")]
        public string Inquiry { get; set; }

        /// <summary>
        /// If <c>resource</c> is the type, the resource token.
        /// </summary>
        [JsonProperty("resource")]
        [STJS.JsonPropertyName("resource")]
        public string Resource { get; set; }

        /// <summary>
        /// The type of the reference. If the type is "inquiry", the inquiry token can be found in
        /// the "inquiry" field. Otherwise the type is an API resource, the token for which can be
        /// found in the "resource" field.
        /// One of: <c>inquiry</c>, <c>payment_method</c>, or <c>person</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

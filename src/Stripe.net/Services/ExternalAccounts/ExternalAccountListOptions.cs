// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ExternalAccountListOptions : ListOptions, IHasObject
    {
        /// <summary>
        /// Filter external accounts according to a particular object type.
        /// One of: <c>bank_account</c>, or <c>card</c>.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }
    }
}

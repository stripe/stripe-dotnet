// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TaxIdListOptions : ListOptions
    {
        /// <summary>
        /// The account or customer the tax ID belongs to. Defaults to <c>owner[type]=self</c>.
        /// </summary>
        [JsonProperty("owner")]
        [STJS.JsonPropertyName("owner")]
        public TaxIdOwnerOptions Owner { get; set; }
    }
}

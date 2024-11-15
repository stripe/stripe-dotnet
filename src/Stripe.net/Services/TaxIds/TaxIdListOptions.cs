// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TaxIdListOptions : ListOptions
    {
        /// <summary>
        /// The account or customer the tax ID belongs to. Defaults to <c>owner[type]=self</c>.
        /// </summary>
        [JsonProperty("owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
#endif

        public TaxIdOwnerOptions Owner { get; set; }
    }
}

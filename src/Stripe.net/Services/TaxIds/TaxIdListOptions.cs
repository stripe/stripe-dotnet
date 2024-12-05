// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdListOptions : ListOptions
    {
        /// <summary>
        /// The account or customer the tax ID belongs to. Defaults to <c>owner[type]=self</c>.
        /// </summary>
        [JsonProperty("owner")]
        public TaxIdOwnerOptions Owner { get; set; }
    }
}

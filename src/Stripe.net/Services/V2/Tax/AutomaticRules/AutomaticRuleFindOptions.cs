// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AutomaticRuleFindOptions : BaseOptions
    {
        /// <summary>
        /// The BillableItem ID to search by.
        /// </summary>
        [JsonProperty("billable_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billable_item")]
#endif
        public string BillableItem { get; set; }
    }
}

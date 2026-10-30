// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormSelfFundingContextSourceOfWealth : StripeEntity<FormSelfFundingContextSourceOfWealth>
    {
        /// <summary>
        /// A text explanation of the connected account's source of wealth.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// IDs of uploaded files evidencing the source of wealth.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }
    }
}

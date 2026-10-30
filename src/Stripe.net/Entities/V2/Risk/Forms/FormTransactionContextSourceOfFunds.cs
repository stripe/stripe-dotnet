// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormTransactionContextSourceOfFunds : StripeEntity<FormTransactionContextSourceOfFunds>
    {
        /// <summary>
        /// A text explanation of where the funds for the transaction came from.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// IDs of uploaded files evidencing the source of funds.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }
    }
}

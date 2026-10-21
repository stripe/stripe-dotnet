// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormSubject : StripeEntity<FormSubject>
    {
        /// <summary>
        /// Account field paths the connected account must review. These are currently returned in
        /// v2 Accounts API format, such as <c>defaults.profile.product_description</c>. Present for
        /// reviewed fields Forms.
        /// </summary>
        [JsonProperty("fields_to_review")]
        [STJS.JsonPropertyName("fields_to_review")]
        public List<string> FieldsToReview { get; set; }

        /// <summary>
        /// IDs of the transactions this Form is about. Present for transaction context Forms.
        /// </summary>
        [JsonProperty("transactions")]
        [STJS.JsonPropertyName("transactions")]
        public List<string> Transactions { get; set; }
    }
}

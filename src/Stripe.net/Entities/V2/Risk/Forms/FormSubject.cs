// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormSubject : StripeEntity<FormSubject>
    {
        /// <summary>
        /// ID of the transaction this Form is about. Present only for transaction_context Forms.
        /// Absent for other Form types.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// IDs of the transactions this inquiry is about.
        /// </summary>
        [JsonProperty("transactions")]
        [STJS.JsonPropertyName("transactions")]
        public List<string> Transactions { get; set; }
    }
}

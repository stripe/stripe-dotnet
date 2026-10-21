// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormTransactionContext : StripeEntity<FormTransactionContext>
    {
        /// <summary>
        /// How often the connected account expects transactions like this one. Can be
        /// <c>one_time_payment</c>, <c>recurring_subscription</c>, <c>repeat_customer</c>,
        /// <c>split_payment</c>, or <c>something_else</c>. A custom explanation can follow
        /// <c>something_else: </c>.
        /// </summary>
        [JsonProperty("frequency")]
        [STJS.JsonPropertyName("frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// The purpose of the transaction.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// IDs of uploaded files evidencing the purpose of the transaction.
        /// </summary>
        [JsonProperty("purpose_files")]
        [STJS.JsonPropertyName("purpose_files")]
        public List<string> PurposeFiles { get; set; }

        /// <summary>
        /// The connected account's relationship to the sender.
        /// </summary>
        [JsonProperty("sender_relationship")]
        [STJS.JsonPropertyName("sender_relationship")]
        public string SenderRelationship { get; set; }

        [JsonProperty("source_of_funds")]
        [STJS.JsonPropertyName("source_of_funds")]
        public FormTransactionContextSourceOfFunds SourceOfFunds { get; set; }

        /// <summary>
        /// How the funds from the transaction will be used.
        /// </summary>
        [JsonProperty("use_of_funds")]
        [STJS.JsonPropertyName("use_of_funds")]
        public string UseOfFunds { get; set; }
    }
}

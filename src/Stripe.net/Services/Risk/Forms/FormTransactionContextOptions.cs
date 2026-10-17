// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormTransactionContextOptions : INestedOptions
    {
        /// <summary>
        /// How often the connected account expects transactions like this one. One of
        /// one_time_payment, recurring_subscription, repeat_customer, split_payment, or
        /// something_else.
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

        /// <summary>
        /// Where the funds for the transaction came from.
        /// </summary>
        [JsonProperty("source_of_funds")]
        [STJS.JsonPropertyName("source_of_funds")]
        public FormTransactionContextSourceOfFundsOptions SourceOfFunds { get; set; }

        /// <summary>
        /// How the funds from the transaction will be used.
        /// </summary>
        [JsonProperty("use_of_funds")]
        [STJS.JsonPropertyName("use_of_funds")]
        public string UseOfFunds { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUpdateTransactionContextOptions : INestedOptions
    {
        /// <summary>
        /// The purpose of the transaction.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// The connected account's relationship to the sender. Optional.
        /// </summary>
        [JsonProperty("sender_relationship")]
        [STJS.JsonPropertyName("sender_relationship")]
        public string SenderRelationship { get; set; }

        /// <summary>
        /// Where the funds for the transaction came from.
        /// </summary>
        [JsonProperty("source_of_funds")]
        [STJS.JsonPropertyName("source_of_funds")]
        public FormUpdateTransactionContextSourceOfFundsOptions SourceOfFunds { get; set; }

        /// <summary>
        /// How the funds from the transaction will be used.
        /// </summary>
        [JsonProperty("use_of_funds")]
        [STJS.JsonPropertyName("use_of_funds")]
        public string UseOfFunds { get; set; }
    }
}

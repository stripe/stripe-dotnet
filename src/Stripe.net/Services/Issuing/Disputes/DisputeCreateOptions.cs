namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount to dispute, defaults to full value, given in the currency
        /// the transaction was made in.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The ID of the issuing transaction to create a dispute for.
        /// </summary>
        [JsonProperty("disputed_transaction")]
        public string DisputedTransaction { get; set; }

        /// <summary>
        /// A hash containing all the evidence related to the dispute. This
        /// should have a single key, equal to the provided <c>Reason</c>, mapping to
        /// an appropriate evidence object.
        /// </summary>
        [JsonProperty("evidence")]
        public EvidenceOptions Evidence { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can
        /// be useful for storing additional information about the object in a
        /// structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The reason for the dispute. One of other or fraudulent.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}

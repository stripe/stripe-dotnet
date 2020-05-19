namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Reason why the <see cref="Status"/> of this card is <c>canceled</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// A set of key-value pairs that you can attach to an object. It
        /// can be useful for storing additional information about the object
        /// in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Spending controls that give you some control over how your cards can be used.
        /// </summary>
        [JsonProperty("spending_controls")]
        public CardSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Whether authorizations can be approved on this card. Defaults to <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

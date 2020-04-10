namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Spending rules that give you some control over how your cards can
        /// be used.
        /// </summary>
        [JsonProperty("authorization_controls")]
        public AuthorizationControlsOptions AuthorizationControls { get; set; }

        [Obsolete("This parameter does not exist and was added to the library incorrectly.")]
        [JsonProperty("billing")]
        public BillingOptions Billing { get; set; }

        /// <summary>
        /// Reason why the card is being canceled.
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

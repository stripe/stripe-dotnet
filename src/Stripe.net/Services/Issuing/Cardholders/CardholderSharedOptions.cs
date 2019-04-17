namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderSharedOptions : BaseOptions
    {
        /// <summary>
        /// Spending rules that give you control over how your cardholders can make charges.
        /// </summary>
        [JsonProperty("authorization_controls")]
        public AuthorizationControlsOptions AuthorizationControls { get; set; }

        /// <summary>
        /// The cardholder’s billing address.
        /// </summary>
        [JsonProperty("billing")]
        public BillingOptions Billing { get; set; }

        /// <summary>
        /// The cardholder’s email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Specifies whether to set this as the default cardholder.
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the charge in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder’s name. This will be printed on cards issued to them.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Maximum amount allowed to spend per time interval.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Specifies whether to permit authorizations on this cardholder’s cards. Possible values
        /// are <c>active</c> or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

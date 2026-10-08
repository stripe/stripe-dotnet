// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentSettings : StripeEntity<SessionPaymentSettings>, IHasMetadata
    {
        /// <summary>
        /// Configures an application fee transferred to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_data")]
        [STJS.JsonPropertyName("application_fee_data")]
        public SessionPaymentSettingsApplicationFeeData ApplicationFeeData { get; set; }

        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
        [STJS.JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with the payment method collected by
        /// this Checkout Session.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Text that appears on the customer's statement as the statement descriptor for a non-card
        /// charge. This value overrides the account's default statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Configures automatic transfers to a connected account when payments succeed.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public SessionPaymentSettingsTransferData TransferData { get; set; }

        /// <summary>
        /// A string that identifies the initial payment as part of a group.
        /// </summary>
        [JsonProperty("transfer_group")]
        [STJS.JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}

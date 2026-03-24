// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentDecrementAuthorizationOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The updated total amount that you intend to collect from the cardholder. This amount
        /// must be smaller than the currently authorized amount and greater than the already
        /// captured amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total amount captured. For more
        /// information, see the PaymentIntents <a
        /// href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        [STJS.JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Automations to be run during the PaymentIntent lifecycle.
        /// </summary>
        [JsonProperty("hooks")]
        [STJS.JsonPropertyName("hooks")]
        public PaymentIntentHooksOptions Hooks { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The parameters used to automatically create a transfer after the payment is captured.
        /// Learn more about the <a href="https://docs.stripe.com/payments/connected-accounts">use
        /// case for connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }
    }
}

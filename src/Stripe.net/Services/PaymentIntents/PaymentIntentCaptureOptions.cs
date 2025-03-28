// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentCaptureOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount to capture from the PaymentIntent, which must be less than or equal to the
        /// original amount. Defaults to the full <c>amount_capturable</c> if it's not provided.
        /// </summary>
        [JsonProperty("amount_to_capture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_to_capture")]
#endif
        public long? AmountToCapture { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total amount captured. For more
        /// information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Automations to be run during the PaymentIntent lifecycle.
        /// </summary>
        [JsonProperty("async_workflows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("async_workflows")]
#endif
        public PaymentIntentAsyncWorkflowsOptions AsyncWorkflows { get; set; }

        /// <summary>
        /// Defaults to <c>true</c>. When capturing a PaymentIntent, setting <c>final_capture</c> to
        /// <c>false</c> notifies Stripe to not release the remaining uncaptured funds to make sure
        /// that they're captured in future requests. You can only use this setting when <a
        /// href="https://stripe.com/docs/payments/multicapture">multicapture</a> is available for
        /// PaymentIntents.
        /// </summary>
        [JsonProperty("final_capture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("final_capture")]
#endif
        public bool? FinalCapture { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Provides industry-specific information about the charge.
        /// </summary>
        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public PaymentIntentPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Text that appears on the customer's statement as the statement descriptor for a non-card
        /// charge. This value overrides the account's default statement descriptor. For information
        /// about requirements, including the 22-character limit, see <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement
        /// Descriptor docs</a>.
        ///
        /// Setting this value for a card charge returns an error. For card charges, set the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#dynamic">statement_descriptor_suffix</a>
        /// instead.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The parameters that you can use to automatically create a transfer after the payment is
        /// captured. Learn more about the <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public PaymentIntentTransferDataOptions TransferData { get; set; }
    }
}

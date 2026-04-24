// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCaptureOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Provides industry-specific information about the amount.
        /// </summary>
        [JsonProperty("amount_details")]
        [STJS.JsonPropertyName("amount_details")]
        public OffSessionPaymentCaptureAmountDetailsOptions AmountDetails { get; set; }

        /// <summary>
        /// The amount to capture.
        /// </summary>
        [JsonProperty("amount_to_capture")]
        [STJS.JsonPropertyName("amount_to_capture")]
        public long? AmountToCapture { get; set; }

        /// <summary>
        /// The amount of the application fee for this capture.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        [STJS.JsonPropertyName("application_fee_amount")]
        public V2.Amount ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Learn more about <a
        /// href="https://docs.stripe.com/payments/payment-intents#storing-information-in-metadata">storing
        /// information in metadata</a>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Provides industry-specific information about the payment.
        /// </summary>
        [JsonProperty("payment_details")]
        [STJS.JsonPropertyName("payment_details")]
        public OffSessionPaymentCapturePaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Text that appears on the customer’s statement as the statement descriptor for a non-card
        /// charge. This value overrides the account’s default statement descriptor. For information
        /// about requirements, including the 22-character limit, see the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">Statement
        /// Descriptor docs</a>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The data that automatically creates a Transfer after the payment finalizes. Learn more
        /// about the use case for <a
        /// href="https://docs.stripe.com/payments/connected-accounts">connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public OffSessionPaymentCaptureTransferDataOptions TransferData { get; set; }
    }
}

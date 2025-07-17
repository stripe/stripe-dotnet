// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The “presentment amount” to be collected from the customer.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The frequency of the underlying payment.
        /// One of: <c>recurring</c>, or <c>unscheduled</c>.
        /// </summary>
        [JsonProperty("cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cadence")]
#endif
        public string Cadence { get; set; }

        /// <summary>
        /// ID of the Customer to which this OffSessionPayment belongs.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.corp.stripe.com/api/metadata">key-value pairs</a> that you
        /// can attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Learn more about <a
        /// href="https://docs.corp.stripe.com/payments/payment-intents#storing-information-in-metadata">storing
        /// information in metadata</a>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the OffSessionPayment are intended.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the payment method used in this OffSessionPayment.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Details about the OffSessionPayment retries.
        /// </summary>
        [JsonProperty("retry_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retry_details")]
#endif
        public OffSessionPaymentCreateRetryDetailsOptions RetryDetails { get; set; }

        /// <summary>
        /// Text that appears on the customer’s statement as the statement descriptor for a non-card
        /// charge. This value overrides the account’s default statement descriptor. For information
        /// about requirements, including the 22-character limit, see the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">Statement
        /// Descriptor docs</a>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account’s <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer’s statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Test clock that can be used to advance the retry attempts in a sandbox.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }

        /// <summary>
        /// The data that automatically creates a Transfer after the payment finalizes. Learn more
        /// about the use case for <a
        /// href="https://docs.corp.stripe.com/payments/connected-accounts">connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public OffSessionPaymentCreateTransferDataOptions TransferData { get; set; }
    }
}

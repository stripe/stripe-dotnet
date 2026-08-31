// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentIntentDataOptions : INestedOptions, IHasMetadata, IHasSetTracking
    {
        private string description;
        private Dictionary<string, string> metadata;
        private string receiptEmail;
        private string setupFutureUsage;
        private string statementDescriptor;
        private string statementDescriptorSuffix;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

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
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("capture_method")]
        [STJS.JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users. Pass
        /// an empty string to clear a previously configured value.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("description")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Description
        {
            get => this.description;
            set
            {
                this.description = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The Stripe account ID for which these funds are intended. For details, see the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/connected-accounts">use case
        /// for connected accounts</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to. If
        /// <c>receipt_email</c> is specified for a payment in live mode, a receipt will be sent
        /// regardless of your <a href="https://dashboard.stripe.com/account/emails">email
        /// settings</a>. Pass an empty string to clear a previously configured recipient.
        /// </summary>
        [JsonProperty("receipt_email", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("receipt_email")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ReceiptEmail
        {
            get => this.receiptEmail;
            set
            {
                this.receiptEmail = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Indicates that you intend to <a
        /// href="https://docs.stripe.com/payments/payment-intents#future-usage">make future
        /// payments</a> with the payment method collected by this Checkout Session.
        ///
        /// When setting this to <c>on_session</c>, Checkout will show a notice to the customer that
        /// their payment details will be saved.
        ///
        /// When setting this to <c>off_session</c>, Checkout will show a notice to the customer
        /// that their payment details will be saved and used for future payments.
        ///
        /// If a Customer has been provided or Checkout creates a new Customer, Checkout will attach
        /// the payment method to the Customer.
        ///
        /// If Checkout does not create a Customer, the payment method is not attached to a
        /// Customer. To reuse the payment method, you can retrieve it from the Checkout Session's
        /// PaymentIntent.
        ///
        /// When processing card payments, Checkout also uses <c>setup_future_usage</c> to
        /// dynamically optimize your payment flow and comply with regional legislation and network
        /// rules, such as SCA.
        ///
        /// Pass an empty string to remove a previously supplied configuration.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("setup_future_usage", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("setup_future_usage")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string SetupFutureUsage
        {
            get => this.setupFutureUsage;
            set
            {
                this.setupFutureUsage = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Shipping information for this payment.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// Text that appears on the customer's statement as the statement descriptor for a non-card
        /// charge. This value overrides the account's default statement descriptor. For information
        /// about requirements, including the 22-character limit, see <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement
        /// Descriptor docs</a>.
        ///
        /// Setting this value for a card charge returns an error. For card charges, set the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#dynamic">statement_descriptor_suffix</a>
        /// instead. Pass an empty string to clear a previously configured value.
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("statement_descriptor")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string StatementDescriptor
        {
            get => this.statementDescriptor;
            set
            {
                this.statementDescriptor = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement. Pass an empty string to clear a previously configured value.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string StatementDescriptorSuffix
        {
            get => this.statementDescriptorSuffix;
            set
            {
                this.statementDescriptorSuffix = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The parameters used to automatically create a Transfer when the payment succeeds. For
        /// more information, see the PaymentIntents <a
        /// href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public SessionPaymentIntentDataTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. See the
        /// PaymentIntents <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers">use case for
        /// connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        [STJS.JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

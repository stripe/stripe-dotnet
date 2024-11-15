// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkPaymentIntentDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif

        public string CaptureMethod { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that will
        /// declaratively set metadata on <a
        /// href="https://stripe.com/docs/api/payment_intents">Payment Intents</a> generated from
        /// this payment link. Unlike object-level metadata, this field is declarative. Updates will
        /// clear prior values.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Indicates that you intend to <a
        /// href="https://stripe.com/docs/payments/payment-intents#future-usage">make future
        /// payments</a> with the payment method collected by this Checkout Session.
        ///
        /// When setting this to <c>on_session</c>, Checkout will show a notice to the customer that
        /// their payment details will be saved.
        ///
        /// When setting this to <c>off_session</c>, Checkout will show a notice to the customer
        /// that their payment details will be saved and used for future payments.
        ///
        /// If a Customer has been provided or Checkout creates a new Customer,Checkout will attach
        /// the payment method to the Customer.
        ///
        /// If Checkout does not create a Customer, the payment method is not attached to a
        /// Customer. To reuse the payment method, you can retrieve it from the Checkout Session's
        /// PaymentIntent.
        ///
        /// When processing card payments, Checkout also uses <c>setup_future_usage</c> to
        /// dynamically optimize your payment flow and comply with regional legislation and network
        /// rules, such as SCA.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_future_usage")]
#endif

        public string SetupFutureUsage { get; set; }

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
        /// A string that identifies the resulting payment as part of a group. See the
        /// PaymentIntents <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">use case for
        /// connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif

        public string TransferGroup { get; set; }
    }
}

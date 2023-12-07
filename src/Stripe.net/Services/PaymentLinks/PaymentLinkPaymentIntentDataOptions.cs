// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkPaymentIntentDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that will
        /// declaratively set metadata on <a
        /// href="https://stripe.com/docs/api/payment_intents">Payment Intents</a> generated from
        /// this payment link. Unlike object-level metadata, this field is declarative. Updates will
        /// clear prior values.
        /// </summary>
        [JsonProperty("metadata")]
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
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Extra information about the payment. This will appear on your customer's statement when
        /// this payment succeeds in creating a charge.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that's set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. See the
        /// PaymentIntents <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">use case for
        /// connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}

namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionPaymentIntentDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount of the application fee (if any) that will be applied to the payment and
        /// transferred to the application owner’s Stripe account.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Capture method of this PaymentIntent, one of <c>automatic</c> or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Stripe account ID for which these funds are intended.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent’s payment
        /// method.
        /// If present, the payment method used with this PaymentIntent can be attached to a
        /// Customer, even after the transaction completes.
        /// Use <c>on_session</c> if you intend to only reuse the payment method when your customer
        /// is present in your checkout flow. Use <c>off_session</c> if your customer may or may
        /// not be in your checkout flow.
        /// Stripe uses this to dynamically optimize your payment flow and comply with regional
        /// legislation and network rules. For example, if your customer is impacted by SCA, using
        /// <c>off_session</c> will ensure that they are authenticated while processing this
        /// PaymentIntent. You will then be able to make later off-session payments for this
        /// customer.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this payment.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// Extra information about the payment. This will appear on your customer’s statement when
        /// this payment succeeds in creating a charge.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The parameters used to automatically create a Transfer when the payment succeeds.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SessionPaymentIntentTransferDataOptions TransferData { get; set; }
    }
}

namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture from the PaymentIntent, which must be less than or equal to the
        /// original amount. Any additional amount will be automatically refunded. Defaults to the
        /// full <c>amount_capturable</c> if not provided.
        /// </summary>
        [JsonProperty("amount_to_capture")]
        public long? AmountToCapture { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be applied to the payment and
        /// transferred to the application owner's Stripe account. Must be greater than zero when
        /// provided. For more information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// For non-card charges, you can use this value as the complete description that appears on
        /// your customers’ statements. Must contain at least one letter, maximum 22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The parameters used to automatically create a Transfer when the payment is captured. For
        /// more information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }
    }
}

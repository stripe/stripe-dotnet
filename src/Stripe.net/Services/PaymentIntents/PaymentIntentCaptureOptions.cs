namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture from the PaymentIntent, which must be less than or equal to the
        /// original amount. Any additional amount will be automatically refunded. Defaults to the
        /// full amount capturable if not provided.
        /// </summary>
        [JsonProperty("amount_to_capture")]
        public long? AmountToCapture { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be applied to the payment and
        /// transferred to the application owner’s Stripe account. For more information, see the
        /// PaymentIntents \<a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">use
        /// case for connected accounts</a>/
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Extra information about a PaymentIntent. This will appear on your customer’s statement
        /// when this PaymentIntent succeeds in creating a charge.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The parameters used to automatically create a Transfer when the payment succeeds. For
        /// more information, see the PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }
    }
}

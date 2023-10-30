// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        ///
        /// If provided, this parameter will override the top-level <c>capture_method</c> when
        /// finalizing the payment with this payment method type.
        ///
        /// If <c>capture_method</c> is already set on the PaymentIntent, providing an empty value
        /// for this parameter will unset the stored value for this payment method type.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// A single-use <c>cvc_update</c> Token that represents a card CVC value. When provided,
        /// the CVC value will be verified during the card payment attempt. This parameter can only
        /// be provided during confirmation.
        /// </summary>
        [JsonProperty("cvc_token")]
        public string CvcToken { get; set; }

        /// <summary>
        /// Installment configuration for payments attempted on this PaymentIntent (Mexico Only).
        ///
        /// For more information, see the <a
        /// href="https://stripe.com/docs/payments/installments">installments integration guide</a>.
        /// </summary>
        [JsonProperty("installments")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsOptions Installments { get; set; }

        /// <summary>
        /// Configuration options for setting up an eMandate for cards issued in India.
        /// </summary>
        [JsonProperty("mandate_options")]
        public PaymentIntentPaymentMethodOptionsCardMandateOptionsOptions MandateOptions { get; set; }

        /// <summary>
        /// When specified, this parameter indicates that a transaction will be marked as MOTO (Mail
        /// Order Telephone Order) and thus out of scope for SCA. This parameter can only be
        /// provided during confirmation.
        /// </summary>
        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        /// <summary>
        /// Selected network to process this PaymentIntent on. Depends on the available networks of
        /// the card attached to the PaymentIntent. Can be only set confirm-time.
        /// One of: <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>interac</c>, <c>jcb</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>unknown</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/docs/payments/extended-authorization">capture beyond the
        /// standard authorization validity window</a> for this PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_extended_authorization")]
        public string RequestExtendedAuthorization { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/docs/payments/incremental-authorization">increment</a> for this
        /// PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_incremental_authorization")]
        public string RequestIncrementalAuthorization { get; set; }

        /// <summary>
        /// Request ability to make <a href="https://stripe.com/docs/payments/multicapture">multiple
        /// captures</a> for this PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_multicapture")]
        public string RequestMulticapture { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/docs/payments/overcapture">overcapture</a> for this
        /// PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_overcapture")]
        public string RequestOvercapture { get; set; }

        /// <summary>
        /// We strongly recommend that you rely on our SCA Engine to automatically prompt your
        /// customers for authentication based on risk level and <a
        /// href="https://stripe.com/docs/strong-customer-authentication">other requirements</a>.
        /// However, if you wish to request 3D Secure based on logic from your own fraud engine,
        /// provide this option. Permitted values include: <c>automatic</c> or <c>any</c>. If not
        /// provided, defaults to <c>automatic</c>. Read our guide on <a
        /// href="https://stripe.com/docs/payments/3d-secure#manual-three-ds">manually requesting 3D
        /// Secure</a> for more information on how this configuration interacts with Radar and our
        /// SCA Engine.
        /// One of: <c>any</c>, or <c>automatic</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// Providing this parameter will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete. If no Customer was
        /// provided, the payment method can still be <a
        /// href="https://stripe.com/docs/api/payment_methods/attach">attached</a> to a Customer
        /// after the transaction completes.
        ///
        /// When processing card payments, Stripe also uses <c>setup_future_usage</c> to dynamically
        /// optimize your payment flow and comply with regional legislation and network rules, such
        /// as <a href="https://stripe.com/docs/strong-customer-authentication">SCA</a>.
        ///
        /// If <c>setup_future_usage</c> is already set and you are performing a request using a
        /// publishable key, you may only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// One of: <c>none</c>, <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the Kana prefix (shortened Kana descriptor) or Kana statement
        /// descriptor that’s set on the account to form the complete statement descriptor. Maximum
        /// 22 characters. On card statements, the <em>concatenation</em> of both prefix and suffix
        /// (including separators) will appear truncated to 22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix_kana")]
        public string StatementDescriptorSuffixKana { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the Kanji prefix (shortened Kanji descriptor) or Kanji statement
        /// descriptor that’s set on the account to form the complete statement descriptor. Maximum
        /// 17 characters. On card statements, the <em>concatenation</em> of both prefix and suffix
        /// (including separators) will appear truncated to 17 characters.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix_kanji")]
        public string StatementDescriptorSuffixKanji { get; set; }
    }
}

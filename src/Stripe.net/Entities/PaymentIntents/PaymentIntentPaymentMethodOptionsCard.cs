// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCard : StripeEntity<PaymentIntentPaymentMethodOptionsCard>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Installment details for this payment (Mexico only).
        ///
        /// For more information, see the <a
        /// href="https://stripe.com/docs/payments/installments">installments integration guide</a>.
        /// </summary>
        [JsonProperty("installments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("installments")]
#endif
        public PaymentIntentPaymentMethodOptionsCardInstallments Installments { get; set; }

        /// <summary>
        /// Configuration options for setting up an eMandate for cards issued in India.
        /// </summary>
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public PaymentIntentPaymentMethodOptionsCardMandateOptions MandateOptions { get; set; }

        /// <summary>
        /// Selected network to process this payment intent on. Depends on the available networks of
        /// the card attached to the payment intent. Can be only set confirm-time.
        /// One of: <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>girocard</c>, <c>interac</c>, <c>jcb</c>, <c>link</c>,
        /// <c>mastercard</c>, <c>unionpay</c>, <c>unknown</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/docs/payments/extended-authorization">capture beyond the
        /// standard authorization validity window</a> for this PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_extended_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_extended_authorization")]
#endif
        public string RequestExtendedAuthorization { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/docs/payments/incremental-authorization">increment the
        /// authorization</a> for this PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_incremental_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_incremental_authorization")]
#endif
        public string RequestIncrementalAuthorization { get; set; }

        /// <summary>
        /// Request ability to make <a href="https://stripe.com/docs/payments/multicapture">multiple
        /// captures</a> for this PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_multicapture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_multicapture")]
#endif
        public string RequestMulticapture { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/docs/payments/overcapture">overcapture</a> for this
        /// PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_overcapture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_overcapture")]
#endif
        public string RequestOvercapture { get; set; }

        /// <summary>
        /// We strongly recommend that you rely on our SCA Engine to automatically prompt your
        /// customers for authentication based on risk level and <a
        /// href="https://stripe.com/docs/strong-customer-authentication">other requirements</a>.
        /// However, if you wish to request 3D Secure based on logic from your own fraud engine,
        /// provide this option. If not provided, this value defaults to <c>automatic</c>. Read our
        /// guide on <a
        /// href="https://stripe.com/docs/payments/3d-secure/authentication-flow#manual-three-ds">manually
        /// requesting 3D Secure</a> for more information on how this configuration interacts with
        /// Radar and our SCA Engine.
        /// One of: <c>any</c>, <c>automatic</c>, or <c>challenge</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_three_d_secure")]
#endif
        public string RequestThreeDSecure { get; set; }

        /// <summary>
        /// When enabled, using a card that is attached to a customer will require the CVC to be
        /// provided again (i.e. using the cvc_token parameter).
        /// </summary>
        [JsonProperty("require_cvc_recollection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("require_cvc_recollection")]
#endif
        public bool RequireCvcRecollection { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a
        /// href="https://stripe.com/payments/save-during-payment">attach the payment method</a> to
        /// the Customer after the PaymentIntent is confirmed and the customer completes any
        /// required actions. If you don't provide a Customer, you can still <a
        /// href="https://stripe.com/api/payment_methods/attach">attach</a> the payment method to a
        /// Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates
        /// and attaches a <a
        /// href="https://stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply
        /// with regional legislation and network rules, such as <a
        /// href="https://stripe.com/strong-customer-authentication">SCA</a>.
        /// One of: <c>none</c>, <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_future_usage")]
#endif
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the Kana prefix (shortened Kana descriptor) or Kana statement
        /// descriptor that’s set on the account to form the complete statement descriptor. Maximum
        /// 22 characters. On card statements, the <em>concatenation</em> of both prefix and suffix
        /// (including separators) will appear truncated to 22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix_kana")]
#endif
        public string StatementDescriptorSuffixKana { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the Kanji prefix (shortened Kanji descriptor) or Kanji statement
        /// descriptor that’s set on the account to form the complete statement descriptor. Maximum
        /// 17 characters. On card statements, the <em>concatenation</em> of both prefix and suffix
        /// (including separators) will appear truncated to 17 characters.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix_kanji")]
#endif
        public string StatementDescriptorSuffixKanji { get; set; }
    }
}

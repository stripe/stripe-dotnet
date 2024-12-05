// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Installment options for card payments.
        /// </summary>
        [JsonProperty("installments")]
        public SessionPaymentMethodOptionsCardInstallmentsOptions Installments { get; set; }

        /// <summary>
        /// Request ability to <a href="https://stripe.com/payments/extended-authorization">capture
        /// beyond the standard authorization validity window</a> for this CheckoutSession.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_extended_authorization")]
        public string RequestExtendedAuthorization { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/payments/incremental-authorization">increment the
        /// authorization</a> for this CheckoutSession.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_incremental_authorization")]
        public string RequestIncrementalAuthorization { get; set; }

        /// <summary>
        /// Request ability to make <a href="https://stripe.com/payments/multicapture">multiple
        /// captures</a> for this CheckoutSession.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_multicapture")]
        public string RequestMulticapture { get; set; }

        /// <summary>
        /// Request ability to <a href="https://stripe.com/payments/overcapture">overcapture</a> for
        /// this CheckoutSession.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_overcapture")]
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
        public string RequestThreeDSecure { get; set; }

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
        /// One of: <c>off_session</c>, or <c>on_session</c>.
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

// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// ConfirmationTokens help transport client side data collected by Stripe JS over to your
    /// server for confirming a PaymentIntent or SetupIntent. If the confirmation is successful,
    /// values present on the ConfirmationToken are written onto the Intent.
    ///
    /// To learn more about how to use ConfirmationToken, visit the related guides: - <a
    /// href="https://stripe.com/docs/payments/finalize-payments-on-the-server">Finalize
    /// payments on the server</a> - <a
    /// href="https://stripe.com/docs/payments/build-a-two-step-confirmation">Build two-step
    /// confirmation</a>.
    /// </summary>
    public class ConfirmationToken : StripeEntity<ConfirmationToken>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which this ConfirmationToken expires and can no longer be used to confirm a
        /// PaymentIntent or SetupIntent.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// Data used for generating a Mandate.
        /// </summary>
        [JsonProperty("mandate_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_data")]
#endif

        public ConfirmationTokenMandateData MandateData { get; set; }

        /// <summary>
        /// ID of the PaymentIntent that this ConfirmationToken was used to confirm, or null if this
        /// ConfirmationToken has not yet been used.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif

        public string PaymentIntent { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for this ConfirmationToken.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif

        public ConfirmationTokenPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// Payment details collected by the Payment Element, used to create a PaymentMethod when a
        /// PaymentIntent or SetupIntent is confirmed with this ConfirmationToken.
        /// </summary>
        [JsonProperty("payment_method_preview")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_preview")]
#endif

        public ConfirmationTokenPaymentMethodPreview PaymentMethodPreview { get; set; }

        /// <summary>
        /// Return URL used to confirm the Intent.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif

        public string ReturnUrl { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this ConfirmationToken's payment
        /// method.
        ///
        /// The presence of this property will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_future_usage")]
#endif

        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// ID of the SetupIntent that this ConfirmationToken was used to confirm, or null if this
        /// ConfirmationToken has not yet been used.
        /// </summary>
        [JsonProperty("setup_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intent")]
#endif

        public string SetupIntent { get; set; }

        /// <summary>
        /// Shipping information collected on this ConfirmationToken.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif

        public ConfirmationTokenShipping Shipping { get; set; }

        /// <summary>
        /// Indicates whether the Stripe SDK is used to handle confirmation flow. Defaults to
        /// <c>true</c> on ConfirmationToken.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_stripe_sdk")]
#endif

        public bool UseStripeSdk { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentConfirmOptions : BaseOptions
    {
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// ID of the ConfirmationToken used to confirm this SetupIntent.
        ///
        /// If the provided ConfirmationToken contains properties that are also being provided in
        /// this request, such as <c>payment_method</c>, then the values in this request will take
        /// precedence.
        /// </summary>
        [JsonProperty("confirmation_token")]
        public string ConfirmationToken { get; set; }

        [JsonProperty("mandate_data")]
        public SetupIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or saved Source object) to attach to
        /// this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// When included, this hash creates a PaymentMethod that is set as the <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-payment_method"><c>payment_method</c></a>
        /// value in the SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
        public SetupIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate on the payment
        /// method's app or site. If you'd prefer to redirect to a mobile application, you can
        /// alternatively supply an application URI scheme. This parameter is only used for cards
        /// and other redirect-based payment methods.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Set to <c>true</c> when confirming server-side and using Stripe.js, iOS, or Android
        /// client-side SDKs to handle the next actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}

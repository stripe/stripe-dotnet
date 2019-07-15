namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SetupIntentConfirmOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the SetupIntent. Required if a publishable key is used to
        /// confirm the setup intent.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, BankAccount, or saved Source object) to
        /// attach to this SetupIntent
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate on the payment
        /// method’s app or site. If you’d prefer to redirect to a mobile application, you can
        /// alternatively supply an application URI scheme. This parameter is only used for cards
        /// and other redirect-based payment methods.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}

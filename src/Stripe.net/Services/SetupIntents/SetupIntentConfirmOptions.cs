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

        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}

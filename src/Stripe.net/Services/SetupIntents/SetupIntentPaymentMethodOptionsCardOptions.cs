namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// When specified, this parameter signals that a card has been collected as MOTO (Mail
        /// Order Telephone Order) and is thus out of scope for SCA.
        /// </summary>
        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        /// <summary>
        /// Control when to request 3D Secure on this SetupIntent.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}

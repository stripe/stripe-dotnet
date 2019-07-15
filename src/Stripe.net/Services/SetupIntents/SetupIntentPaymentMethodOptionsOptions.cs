namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for any card payments attempted on this SetupIntent.
        /// </summary>
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }
    }
}

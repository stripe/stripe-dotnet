// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions Card { get; set; }
    }
}

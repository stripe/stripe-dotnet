// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerPaymentSettingsPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        public CustomerPaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public CustomerPaymentSettingsPaymentMethodOptionsCardOptions Card { get; set; }
    }
}

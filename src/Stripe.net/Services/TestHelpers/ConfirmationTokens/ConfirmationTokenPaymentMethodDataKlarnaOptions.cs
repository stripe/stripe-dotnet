// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodDataKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Customer's date of birth.
        /// </summary>
        [JsonProperty("dob")]
        public ConfirmationTokenPaymentMethodDataKlarnaDobOptions Dob { get; set; }
    }
}

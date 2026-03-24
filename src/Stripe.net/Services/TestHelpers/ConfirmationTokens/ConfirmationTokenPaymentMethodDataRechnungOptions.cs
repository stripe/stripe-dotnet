// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfirmationTokenPaymentMethodDataRechnungOptions : INestedOptions
    {
        /// <summary>
        /// Customer's date of birth.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public ConfirmationTokenPaymentMethodDataRechnungDobOptions Dob { get; set; }
    }
}

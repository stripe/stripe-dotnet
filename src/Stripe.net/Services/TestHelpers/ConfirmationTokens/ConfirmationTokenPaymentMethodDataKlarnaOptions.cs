// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodDataKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Customer's date of birth.
        /// </summary>
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public ConfirmationTokenPaymentMethodDataKlarnaDobOptions Dob { get; set; }
    }
}

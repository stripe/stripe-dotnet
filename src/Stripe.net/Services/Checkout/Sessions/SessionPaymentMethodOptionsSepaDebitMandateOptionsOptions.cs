// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionPaymentMethodOptionsSepaDebitMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Prefix used to generate the Mandate reference. Must be at most 12 characters long. Must
        /// consist of only uppercase letters, numbers, spaces, or the following special characters:
        /// '/', '_', '-', '&amp;', '.'. Cannot begin with 'STRIPE'.
        /// </summary>
        [JsonProperty("reference_prefix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_prefix")]
#endif
        public string ReferencePrefix { get; set; }
    }
}

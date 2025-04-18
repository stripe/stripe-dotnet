// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for any card payments confirmed using this ConfirmationToken.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public ConfirmationTokenPaymentMethodOptionsCardOptions Card { get; set; }
    }
}

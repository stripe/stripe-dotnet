// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Installment configuration for payments confirmed using this ConfirmationToken.
        /// </summary>
        [JsonProperty("installments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("installments")]
#endif
        public ConfirmationTokenPaymentMethodOptionsCardInstallmentsOptions Installments { get; set; }
    }
}

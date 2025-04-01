// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// The selected installment plan to use for this payment attempt. This parameter can only
        /// be provided during confirmation.
        /// </summary>
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public ConfirmationTokenPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfirmationTokenPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Installment configuration for payments confirmed using this ConfirmationToken.
        /// </summary>
        [JsonProperty("installments")]
        [STJS.JsonPropertyName("installments")]
        public ConfirmationTokenPaymentMethodOptionsCardInstallmentsOptions Installments { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantKonbiniPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Information provided to support the onboarding process for Konbini payments.
        /// </summary>
        [JsonProperty("additional_material")]
        [STJS.JsonPropertyName("additional_material")]
        public string AdditionalMaterial { get; set; }

        /// <summary>
        /// Support for Konbini payments.
        /// </summary>
        [JsonProperty("support")]
        [STJS.JsonPropertyName("support")]
        public AccountCreateConfigurationMerchantKonbiniPaymentsSupportOptions Support { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationMerchantKonbiniPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Support for Konbini payments.
        /// </summary>
        [JsonProperty("support")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support")]
#endif
        public AccountCreateConfigurationMerchantKonbiniPaymentsSupportOptions Support { get; set; }
    }
}
